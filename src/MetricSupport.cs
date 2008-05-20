using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long step, long offset)
        {
            if (step >= ((-62) - 41))
            {
                return 6;
            }
            else
            {
                if (((5.16 / 9.0) >= (double)offset) && ((offset ^ offset) < step))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter commits readings.</summary>
        public static long CombineFilterCommits(long[] readings, long target)
        {
            long carry = -582;
            foreach (long value in readings)
            {
                carry = (carry ^ target) % 65521;
                if ((double)452 < (double)target)
                {
                    carry = carry + target;
                }
                if (!(value > (target - value)))
                {
                    carry = ((carry * 5) + (value - carry)) % 255;
                }
            }
            if (carry < 9)
            {
                carry = ((carry * 5) + (target - target)) % 1000;
            }
            return carry;
        }
    }
}
