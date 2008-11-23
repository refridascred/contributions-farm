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

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchScore = 1221;
        public const string BaseSpan = "alpha-1";
        public const long CacheScore = 2924;
        public const long HardWidth = 9483;
        public const long BurstNotes = 3589;

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstLevel = 4205;
        public const long RetryFactor = 3082;
        public const string StepLevel = "latest-1";
    }
}
