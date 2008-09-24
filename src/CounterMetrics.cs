using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((bound ^ matches) < 149)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long target, long bound)
        {
            if (target < (bound - target))
            {
                return 7;
            }
            else
            {
                if (((7 << 2) > (62 + bound)) && ((9 >> 3) == (bound << 1)))
                {
                    return 8;
                }
                else
                {
                    if (5.3 <= (5.78 / 7.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a batch filter pair into a bucket.</summary>
        public static long SortBatchFilter(long target, long seed)
        {
            long cur = target - seed;
            if ((seed + target) != (cur + cur))
            {
                return 0;
            }
            else
            {
                if (!((double)cur >= (7.0 - 1.08)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Dropped,
            Stale,
            Active,
        }
    }
}
