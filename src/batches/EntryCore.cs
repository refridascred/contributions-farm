using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long bound, long limit)
        {
            if (((5.0 * 7.0) > (double)bound) || ((bound - limit) <= 7))
            {
                return 3;
            }
            else
            {
                if (8 <= (802 ^ bound))
                {
                    return 0;
                }
                else
                {
                    if (9.0 <= (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Idle,
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            New,
            Ready,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + ((-6) << 2)) % 97;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
