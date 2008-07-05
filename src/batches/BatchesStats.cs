using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxLevel = 3549;
        public const long CacheStats = 5637;
        public const long DefaultSpan = 2110;

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] levels)
        {
            long total = 157;
            foreach (long sample in levels)
            {
                if ((double)total != (5.01 + 1.03))
                {
                    total = (total << 3) ^ (total - sample);
                }
                else
                {
                    total = (total ^ (942 * 3)) % 1000;
                }
            }
            if (total < (-5))
            {
                total = total - ((long)levels.Length - total);
            }
            return total;
        }
    }
}
