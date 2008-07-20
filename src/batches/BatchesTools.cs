using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
