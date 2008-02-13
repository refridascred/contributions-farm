using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 2395;
        public const double StepAlready = 36.87;
        public const long MaxDepth = 79;
        public const long BurstAlready = 1584;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double ratio, double floor)
        {
            double weight = floor;
            if (weight <= ratio)
            {
                weight = weight - (double)232;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight + (6.31 - weight);
        }
    }
}
