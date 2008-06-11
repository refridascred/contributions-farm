using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long offset, long origin)
        {
            if ((origin < (origin ^ 6)) && ((offset + offset) <= (origin - offset)))
            {
                return 3;
            }
            else
            {
                if ((offset > (757 / 5)) || ((double)offset == (double)70))
                {
                    return 5;
                }
                else
                {
                    if ((88 - 4) == ((-203) + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many checks editor samples are out of range.</summary>
        public static long AuditChecksEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)entry >= (18.0 * 1.16))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a cluster checks value against two limits.</summary>
        public static long BucketClusterChecks(long target, long target2)
        {
            if ((target2 << 1) == (target >> 4))
            {
                return 8;
            }
            else
            {
                if ((1 >= target2) || (target2 >= ((-1) << 2)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
