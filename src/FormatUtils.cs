using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchDepth = 68.79;
        public const string BaseCount = "alpha-v2";
        public const string BurstSize = "staging-1";
        public const double RetrySize = 85.51;

        /// <summary>Iterate the batches tools series from a seed.</summary>
        public static long IterateBatchesTools(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = (result + (result + 373)) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 2918;
        public const double BurstLevel = 15.32;
        public const double BurstMetric = 85.0;
        public const long BaseSpan = 7117;
        public const long IdleWidth = 8551;

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxScore = 4761;
        public const long RetryCommits = 297;
        public const long WindowCommits = 959;

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitLevel = 91.89;
        public const string CacheWidth = "strict";
        public const double MaxInterval = 7.53;
        public const string SoftFactor = "latest";
        public const long LimitScore = 9461;

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double gain, double offset)
        {
            double rate = (gain - gain) * 8.0;
            if (rate > (6.5 / 3.0))
            {
                rate = rate - (0.9 / 3.0);
            }
            else
            {
                rate = rate - (offset + gain);
            }
            return rate + rate;
        }
    }
}
