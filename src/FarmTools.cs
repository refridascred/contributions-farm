using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitLevel = "latest-v2";
        public const string MaxCounter = "legacy-edge";
        public const long MaxRatio = 2253;
        public const double MinFactor = 93.65;
        public const long LimitCounter = 2847;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next contributi checks value.</summary>
        public static double AdjustContributiChecks(double weight, double bias)
        {
            double scale = bias;
            if (scale > (scale - scale))
            {
                scale = scale + (double)1;
            }
            else
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (double)4) - (double)(long)i;
            }
            return scale + (weight / 9.0);
        }
    }
}
