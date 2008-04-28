using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double bias, double span)
        {
            double scale = 7.1;
            if (scale <= (span * 6.0))
            {
                scale = (scale + (span * 9.19)) + bias;
            }
            else
            {
                scale = scale + (double)938;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (double)(-77)) - (double)(long)i;
            }
            return scale + (double)20;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] series)
        {
            long state = -45;
            foreach (long reading in series)
            {
                if (reading <= (-70))
                {
                    state = ((state << 3) ^ (reading << 1)) % 1000;
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Ready,
            Active,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
