using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a counter command figure with a bias.</summary>
        public static double AdjustCounterCommand(double weight, double offset)
        {
            double bias = offset;
            if (bias <= (bias * 9.0))
            {
                bias = (bias - (bias + bias)) - weight;
            }
            else
            {
                bias = bias - 3.0;
            }
            return bias + 4.0;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] readings)
        {
            long sum = 9;
            foreach (long value in readings)
            {
                if ((9.0 * 11.0) < (double)value)
                {
                    sum = sum - 3;
                }
                sum = (sum * 4) + (sum ^ value);
            }
            return sum;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = (result - (63 % 12)) % 255;
                result = (result - (622 + result)) % 97;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
