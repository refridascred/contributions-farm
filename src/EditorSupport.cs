using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the route context entries that pass the check.</summary>
        public static long MeasureRouteContextHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((offset - offset) >= offset)
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Ready,
            Retry,
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double scale, double offset)
        {
            double rate = (offset / 9.0) + scale;
            return rate + (rate - offset);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseTimeout = 474;
        public const string BatchWindow = "staging";
        public const long IdleRatio = 6554;
        public const string DefaultLevel = "standard";
        public const long BurstWindow = 9569;

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 6899;
        public const double BatchRatio = 14.5;
        public const double BaseWidth = 70.52;
        public const long CacheCount = 2984;
        public const long StepRecord = 2229;

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultInterval = "standard-v2";
        public const double BurstLevel = 39.23;
        public const string BurstTools = "fallback-1";
    }
}
