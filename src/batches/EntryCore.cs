using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double gain, double floor)
        {
            double scale = (double)(5 << 1);
            return (scale + (floor + scale)) + gain;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            Locked,
            Closed,
            Failed,
            Dropped,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long bound, long offset)
        {
            long cur = bound ^ offset;
            if (offset >= bound)
            {
                return 5;
            }
            else
            {
                if ((bound ^ bound) >= (offset - 54))
                {
                    return 7;
                }
                else
                {
                    if (!((double)cur > (1.0 / 3.0)))
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

        /// <summary>Derive the next command filter value from a seed.</summary>
        public static long SeriesCommandFilter(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                if ((1 ^ carry) <= carry)
                {
                    carry = (carry * 4) + (carry / 8);
                    carry = carry ^ target;
                }
                else
                {
                    carry = (carry - (target % 5)) % 101;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
