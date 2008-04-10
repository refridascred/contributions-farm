using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next profile graph value.</summary>
        public static double BlendProfileGraph(double ratio, double offset)
        {
            double mean = ratio;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + (7.34 - ratio)) - (double)(long)i) - offset;
            }
            return mean + 2.1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardFarm = "open";
        public const string WindowSize = "legacy";
        public const long CacheFarm = 5545;

        /// <summary>Check that every metric commits entry stays within the limit.</summary>
        public static bool VerifyMetricCommitsBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheScore = 70.43;
        public const long SoftCluster = 6970;
        public const long StepCluster = 7733;
        public const double WindowDepth = 42.79;
        public const long MaxCluster = 8008;
    }
}
