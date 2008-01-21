using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((origin - carry) < (carry >> 1))
                {
                    carry = (carry ^ carry) % 255;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Validate counter context readings against a bound.</summary>
        public static bool GuardCounterContextRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
