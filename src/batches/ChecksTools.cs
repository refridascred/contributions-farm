using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first account support entry that matches the target.</summary>
        public static long FindAccountSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (0 <= (hits % 3))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxInterval = 3584;
        public const string IdleLevel = "latest";
        public const string SoftCommand = "cached-1";

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long target, long seed)
        {
            if (seed > target)
            {
                return 5;
            }
            else
            {
                if (seed <= target)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
