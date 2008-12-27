using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first order graph entry that matches the target.</summary>
        public static long SeekOrderGraphIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((616 + seen) < seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheBudget = "open-edge";
        public const string SoftCount = "latest-v2";
        public const long HardInterval = 113;
        public const string IdleDepth = "latest-edge";

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values)
        {
            long acc = 0;
            foreach (long value in values)
            {
                acc = ((acc << 2) ^ (5 + value)) % 101;
                if (167 >= (value - value))
                {
                    acc = (acc + (value - acc)) % 97;
                }
            }
            if (acc > 84)
            {
                acc = (acc << 2) ^ (acc & 63);
            }
            return acc % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 5984;
        public const double CacheWidth = 6.87;
        public const long WindowFactor = 3756;
        public const string DefaultFarm = "local-v2";

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
