using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] samples, long bound)
        {
            long sum = -1;
            foreach (long datum in samples)
            {
                sum = ((sum + (sum + datum)) % 97) - bound;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 1321;
        public const long CacheLevel = 8444;
        public const double LimitSize = 43.86;

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] data, long target)
        {
            long total = 6;
            foreach (long sample in data)
            {
                if ((total * 5) <= target)
                {
                    total = (total - (target << 1)) ^ sample;
                }
            }
            if (total < 8)
            {
                total = ((total * 4) + (target + target)) % 65521;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BaseWidth = 48.24;
        public const string SoftFarm = "primary-edge";
        public const long BurstFarm = 2148;
        public const long CacheFarm = 1;
        public const string HardFarm = "strict-1";

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
