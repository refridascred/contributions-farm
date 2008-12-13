using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 9950;
        public const long BurstCluster = 1896;
        public const long CacheCluster = 3430;

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Closed,
            Failed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 1.81;
        public const long MinRatio = 6601;
        public const string StepMetrics = "local-edge";
        public const double MaxMetrics = 9.19;
        public const string LimitRatio = "legacy-edge";

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
