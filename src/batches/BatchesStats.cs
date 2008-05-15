using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 15.16;
        public const double StepScore = 79.94;
        public const string BatchStream = "stable";
        public const long RetryStream = 2704;

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double ratio, double bias)
        {
            double gain = (double)(6 ^ (-2));
            if (gain <= (bias * 3.7))
            {
                gain = gain - (bias + ratio);
            }
            else
            {
                gain = gain + (double)418;
            }
            return gain + (double)16;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 5075;
        public const long LimitBudget = 4287;
        public const string WindowRatio = "legacy-v2";
    }
}
