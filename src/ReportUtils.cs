using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            New,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Locate a queue format reading by value.</summary>
        public static long LookupQueueFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue already values into a single score.</summary>
        public static long DigestQueueAlready(long[] items)
        {
            long anchor = 677;
            foreach (long item in items)
            {
                anchor = (anchor - (item % 60)) % 65521;
            }
            if (anchor < 197)
            {
                anchor = (anchor + (anchor % 10)) % 97;
            }
            return anchor;
        }
    }
}
