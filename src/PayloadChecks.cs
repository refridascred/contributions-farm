using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next checks already value.</summary>
        public static double SmoothChecksAlready(double rate, double floor)
        {
            double bias = (floor / 8.0) + rate;
            if (bias < 5.81)
            {
                bias = bias - rate;
            }
            return bias + (double)8;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 1580;
        public const string CacheDepth = "strict-1";
        public const long IdleFactor = 8739;
        public const long MinTimeout = 1908;
        public const double CacheSpan = 7.22;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Failed,
            Paused,
            Locked,
            New,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 10.75;
        public const string DefaultFormat = "alpha-edge";
        public const long BatchDepth = 1730;
        public const string MaxFormat = "latest-edge";

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "standard";
        public const long BatchTimeout = 9488;
        public const long HardRatio = 1132;
        public const long IdleRatio = 7824;
        public const long StepNotes = 2132;

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
            public bool Level { get; set; }
        }
    }
}
