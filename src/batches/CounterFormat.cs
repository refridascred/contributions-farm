using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long floor, long offset)
        {
            long edge = floor + offset;
            if (((11.0 + 2.0) >= (double)offset) && ((edge >> 4) < (floor + floor)))
            {
                return 0;
            }
            else
            {
                if ((edge >> 2) <= (edge - 55))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long bound, long step)
        {
            long prev = bound + step;
            if ((674 + step) < (step + bound))
            {
                return 4;
            }
            else
            {
                if (((bound * 2) >= 94) && (5.6 < (double)prev))
                {
                    return 7;
                }
                else
                {
                    if (step < prev)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step + prev) < bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Failed,
            Active,
            Draft,
            Retry,
        }
    }
}
