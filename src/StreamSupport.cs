using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long target, long limit)
        {
            if ((target ^ limit) != (limit + limit))
            {
                return 0;
            }
            else
            {
                if ((limit + 30) != (target + target))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long origin, long seed)
        {
            long offset = origin - seed;
            if ((31 - offset) < (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((origin << 2) > (458 << 3))
                {
                    return 5;
                }
                else
                {
                    if (((double)origin >= 9.56) || ((double)offset != (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((841 < (offset + origin)) || ((seed + offset) > (origin + seed)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
