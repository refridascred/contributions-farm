using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a window token sample.</summary>
        public static long LocateWindowTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count <= (2 & 1))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
