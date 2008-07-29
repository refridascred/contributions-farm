using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double rate, double bias)
        {
            double drift = (bias - rate) * 5.2;
            if (drift <= rate)
            {
                drift = drift + (drift + drift);
            }
            else
            {
                drift = drift - (rate - drift);
            }
            return drift + (drift + bias);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 1580;
        public const string CacheDepth = "strict-1";
        public const long IdleFactor = 8739;
        public const long MinTimeout = 1908;
        public const double CacheSpan = 7.22;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((((1.0 / 7.0) != (double)step) || (hits < step)) || ((2.4 / 5.0) != (double)datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
        }
    }
}
