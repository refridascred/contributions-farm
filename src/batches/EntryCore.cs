using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
