using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 70.26;
        public const string SoftBudget = "legacy-edge";
        public const long LimitWidth = 8823;
        public const double LimitFactor = 88.55;

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheFactor = 3958;
        public const double BurstDepth = 86.83;
        public const long BatchProfile = 1671;
        public const string HardScore = "legacy-v2";
        public const long MaxInterval = 8059;

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] levels, long target)
        {
            long acc = 97;
            foreach (long item in levels)
            {
                acc = ((acc - target) % 101) ^ item;
            }
            return acc;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double ratio, double offset)
        {
            double rate = offset;
            if (rate >= (rate - ratio))
            {
                rate = rate - ratio;
            }
            else
            {
                rate = rate + offset;
            }
            return rate - offset;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
