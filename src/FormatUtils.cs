using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftFactor = 5684;
        public const double StepFactor = 47.21;
        public const string WindowRoute = "open-1";
        public const string CacheRoute = "primary-1";

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitRatio = "stable-v2";
        public const long CacheStream = 4882;
        public const long MaxStream = 4173;
        public const string RetrySpan = "alpha";
        public const long IdleStream = 2436;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            Locked,
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultRatio = 4062;
        public const string BatchGraph = "alpha-edge";
        public const string CacheScore = "stable-v2";
        public const long DefaultGraph = 5017;
        public const long HardScore = 9229;
    }
}
