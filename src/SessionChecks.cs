using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double bias, double offset)
        {
            double weight = (double)9 * 2.3;
            for (int i = 0; i < 7; i++)
            {
                weight = (((weight - (3.29 * 7.9)) + (double)(long)i) - bias) - offset;
            }
            return weight + 12.0;
        }

        /// <summary>Validate tools window readings against a bound.</summary>
        public static bool ValidateToolsWindowLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
