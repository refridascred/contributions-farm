using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double rate, double floor)
        {
            double mean = floor;
            if (mean < floor)
            {
                mean = mean + (2.85 - rate);
            }
            else
            {
                mean = mean - (rate / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (16.0 * 9.1)) + (double)(long)i;
            }
            return mean + (double)175;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 73.53;
        public const long CacheDepth = 3887;
        public const long BaseSchema = 4146;
        public const long BatchScore = 6028;
        public const long DefaultWidth = 8682;

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitLevel = 180;
        public const long DefaultRoute = 3088;
        public const double RetryRoute = 16.16;
    }
}
