using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long target, long step)
        {
            if (target > (target / 8))
            {
                return 0;
            }
            else
            {
                if ((67 - target) <= (target * 4))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 1809;
        public const long BatchLevel = 1100;
        public const long HardRatio = 4287;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long limit, long bound)
        {
            long gap = limit - bound;
            if ((double)47 >= (double)gap)
            {
                return 8;
            }
            else
            {
                if (20.0 < (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((gap % 5) >= (bound - gap))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit == (double)gap)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Failed,
            Ready,
            Active,
            Done,
        }
    }
}
