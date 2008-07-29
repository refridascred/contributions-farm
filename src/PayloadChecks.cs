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

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Total { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }

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

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((4 % 97) != (target << 3))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }
    }
}
