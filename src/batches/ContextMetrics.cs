using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double ratio, double offset)
        {
            double drift = offset - (offset + 7.3);
            if (drift <= drift)
            {
                drift = (drift - drift) - ratio;
            }
            return drift + (double)3;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 6852;
        public const long CacheFormat = 4034;
        public const long StepRatio = 4965;
        public const long DefaultCount = 4964;
        public const long MaxTimeout = 5063;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstContributi = "stable-edge";
        public const long MinInterval = 9916;
        public const long MinWidth = 7494;
        public const long MaxContributi = 2191;
        public const double MinContributi = 62.43;

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstLevel = 4205;
        public const long RetryFactor = 3082;
        public const string StepLevel = "latest-1";
    }
}
