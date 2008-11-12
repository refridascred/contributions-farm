using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Score { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the cache queue entries that pass the check.</summary>
        public static long TallyCacheQueueHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell != (double)floor)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
