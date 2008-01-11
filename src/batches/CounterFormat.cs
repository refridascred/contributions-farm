using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)hits > (12.0 + 9.0))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
