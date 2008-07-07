using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            Done,
            Queued,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultLevel = "legacy-edge";
        public const double MaxFilter = 37.0;
        public const long MinFilter = 326;
        public const string StepFilter = "stable";
        public const double CacheSize = 80.05;

        /// <summary>Blend two cluster farm measurements.</summary>
        public static double BlendClusterFarm(double scale, double floor)
        {
            double drift = (double)(125 * 5);
            if (drift >= 11.0)
            {
                drift = (drift - 3.0) - scale;
            }
            return drift + floor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseTools = "strict-v2";
        public const double IdleSpan = 57.86;
        public const long RetryInterval = 714;
        public const long MaxLevel = 1151;
        public const long IdleScore = 9235;
    }
}
