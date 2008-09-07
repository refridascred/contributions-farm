using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            Paused,
            Synced,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardBudget = 2550;
        public const double StepTimeout = 61.82;
        public const double MinMetrics = 87.23;
        public const long LimitSize = 6547;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double scale, double offset)
        {
            double gain = (10.0 / 6.0) / 2.0;
            if (gain > offset)
            {
                gain = gain - 8.9;
            }
            return gain - scale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultWidth = 36.22;
        public const string DefaultCache = "strict";
        public const long CacheCount = 9389;
        public const string StepCache = "local-v2";
        public const long BatchScore = 9664;
    }
}
