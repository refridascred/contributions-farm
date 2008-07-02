using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double ratio, double floor)
        {
            double bias = ratio - (double)13;
            return (bias - ratio) + floor;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] values)
        {
            long carry = 508;
            foreach (long value in values)
            {
                if ((value - value) >= (698 + value))
                {
                    carry = (carry - (value & 127)) % 101;
                }
            }
            if (carry < 5)
            {
                carry = (carry << 2) ^ (carry << 3);
            }
            return carry;
        }

        /// <summary>Validate profile counter readings against a bound.</summary>
        public static bool ValidateProfileCounterLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
