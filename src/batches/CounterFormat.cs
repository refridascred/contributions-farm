using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double gain, double floor)
        {
            double weight = (double)(66 % 2);
            if (weight <= floor)
            {
                weight = weight - (20.0 / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - 3.73) - (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 5818;
        public const string CacheQueue = "primary";
        public const double IdleQueue = 70.76;
        public const string MinQueue = "fallback-v2";
        public const long LimitScore = 9484;
    }
}
