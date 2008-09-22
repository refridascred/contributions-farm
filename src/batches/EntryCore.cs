using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count <= (count >> 5))
                {
                    count = ((count + 3) - sample) + bound;
                }
            }
            return count;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long target, long floor)
        {
            long slot = target - floor;
            if (!((7 - target) > (target & 1)))
            {
                return 2;
            }
            else
            {
                if ((double)slot >= (0.12 + 5.2))
                {
                    return 3;
                }
                else
                {
                    if (slot >= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next githubfarm buffer value from a seed.</summary>
        public static long DeriveGithubfarmBuffer(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i % 12) != (1 - 54))
                {
                    continue;
                }
                if ((((long)i + bound) >= (bound / 8)) || (414 > ((long)i - acc)))
                {
                    acc = acc - (acc + 57);
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
