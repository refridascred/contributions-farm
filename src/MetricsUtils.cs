using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 8046;
        public const string MinTools = "primary-v2";
        public const long LimitTools = 2905;
        public const long StepDepth = 7617;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two batch stream measurements.</summary>
        public static double BlendBatchStream(double ratio, double offset)
        {
            double rate = ratio;
            if (rate >= rate)
            {
                rate = (rate + (double)515) - offset;
            }
            return rate + 8.64;
        }

        /// <summary>Derive the next queue buffer value from a seed.</summary>
        public static long IterateQueueBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
