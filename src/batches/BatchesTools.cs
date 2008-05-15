using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double rate, double bias)
        {
            double ratio = (bias + rate) / 4.0;
            if (ratio <= 5.6)
            {
                ratio = ratio - (double)(-177);
            }
            return ratio + (ratio - bias);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepDepth = 8491;
        public const long LimitScore = 2015;
        public const long StepSize = 4034;
        public const long WindowLevel = 2855;
        public const long StepWidth = 7981;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
