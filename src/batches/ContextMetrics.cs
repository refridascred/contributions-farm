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

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "standard-1";
        public const string MaxWindow = "open";
        public const string WindowWidth = "primary-1";
        public const string WindowFactor = "latest";

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
