using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardCount = 6491;
        public const long IdleSpan = 8304;
        public const long BaseReport = 1556;
        public const string SoftReport = "staging-v2";
        public const string SoftTimeout = "fallback-edge";

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] data, long origin)
        {
            long sum = 1;
            foreach (long datum in data)
            {
                if (((datum + sum) > origin) && ((sum << 2) != (sum + sum)))
                {
                    sum = (sum - (datum - (-6))) % 97;
                }
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchInterval = "standard-edge";
        public const long MaxToken = 5476;
        public const double IdleToken = 20.75;
        public const long BaseToken = 813;
        public const long IdleWidth = 457;

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double rate, double span)
        {
            double rate2 = (double)(681 / 5);
            return (rate2 - rate) + span;
        }
    }
}
