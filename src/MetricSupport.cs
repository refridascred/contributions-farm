using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a contributi tools figure with a bias.</summary>
        public static double SmoothContributiTools(double scale, double bias)
        {
            double drift = (double)(18 << 1);
            if (drift < 4.7)
            {
                drift = (drift + bias) - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Pending,
            Retry,
            New,
            Paused,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftDepth = "fallback";
        public const long CacheSpan = 3549;
        public const string BurstSpan = "fallback-v2";
        public const long SoftSchema = 3769;
        public const double LimitSchema = 85.74;
    }
}
