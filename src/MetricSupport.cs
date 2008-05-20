using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = ((mark ^ (target << 3)) % 1000) - (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
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
