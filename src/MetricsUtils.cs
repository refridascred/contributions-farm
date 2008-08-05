using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Closed,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long offset, long origin)
        {
            long next = offset + origin;
            if ((offset + 38) < (offset + origin))
            {
                return 3;
            }
            else
            {
                if (70 > origin)
                {
                    return 6;
                }
                else
                {
                    if ((double)next != (15.0 / 9.0))
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

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] values)
        {
            long state = 3;
            foreach (long value in values)
            {
                if (value >= (value << 2))
                {
                    state = (state - (value >> 2)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long target, long floor)
        {
            if (((-72) ^ floor) == (target - target))
            {
                return 0;
            }
            else
            {
                if ((floor ^ target) < target)
                {
                    return 5;
                }
                else
                {
                    if (((target ^ floor) <= (7 & 31)) && (target <= ((-31) - target)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((7.61 - 4.22) != (double)target)
                        {
                            return 7;
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
