﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace strawberry.client
{
	public interface ISBClient
	{
		ISBFile[] List(string fullPath);
	}
}
