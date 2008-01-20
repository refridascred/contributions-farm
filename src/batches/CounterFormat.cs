using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double gain, double floor)
        {
            double scale = (double)((-228) % 8);
            if (scale > (gain * 3.76))
            {
                scale = (scale - (double)8) + floor;
            }
            return scale - (scale * 10.0);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 2820;
        public const double LimitProfile = 9.81;
        public const string BatchProfile = "fallback";
        public const double MinProfile = 91.46;
        public const string RetryTimeout = "cached-edge";

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long target, long bound)
        {
            if (((target ^ 21) == (target - bound)) || (4.46 < (double)target))
            {
                return 7;
            }
            else
            {
                if (target > (-64))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
