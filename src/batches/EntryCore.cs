using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double weight, double span)
        {
            double bias = span;
            if (bias < (weight / 8.0))
            {
                bias = bias + (bias / 7.0);
            }
            else
            {
                bias = bias + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - weight) - (double)(long)i;
            }
            return bias + (double)41;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double gain, double floor)
        {
            double scale = (double)(5 << 1);
            return (scale + (floor + scale)) + gain;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((seed - seed) <= entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
