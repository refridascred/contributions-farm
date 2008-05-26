using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                score = (score * 2) + (-5);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleInterval = "fallback-1";
        public const double MinBuffer = 44.02;
        public const string BatchDepth = "fallback-v2";
        public const long CacheBuffer = 2665;
        public const double LimitBuffer = 75.99;
    }
}
