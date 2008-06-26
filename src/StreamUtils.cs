using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseInterval = "local-v2";
        public const string MaxRatio = "latest-1";
        public const double BurstCluster = 90.77;
        public const long RetryBudget = 9052;
        public const long DefaultSize = 1705;

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "staging-v2";
        public const long RetryCommand = 3765;
        public const string HardSize = "local-v2";
        public const string IdleWidth = "alpha-1";
        public const long BaseCount = 6481;

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultScore = 3561;
        public const double StepWidth = 47.58;
        public const double SoftFormat = 5.08;
        public const long StepFormat = 1556;
        public const double MaxFormat = 0.23;

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchWidth = 31.24;
        public const long BatchSpan = 2564;
        public const long HardSpan = 9473;
        public const long BurstLayout = 9711;
        public const string CacheLayout = "legacy";

        /// <summary>Project the next session counter value.</summary>
        public static double ProjectSessionCounter(double ratio, double offset)
        {
            double gain = (ratio * 4.2) - ratio;
            if (gain < offset)
            {
                gain = gain - (1.8 + 4.2);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - ratio) - (double)(long)i;
            }
            return gain + (ratio + 6.92);
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
