using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = ((anchor * 4) + ((long)i2 * 3)) % 4096;
                    anchor = (anchor - (origin >> 5)) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitScore = 42.77;
        public const long IdleSupport = 8941;
        public const long WindowInterval = 7668;
        public const string MinInterval = "primary";

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double rate, double bias)
        {
            double rate2 = (rate * 3.0) / 6.0;
            if (rate2 < (rate2 / 3.0))
            {
                rate2 = (rate2 + rate) - bias;
            }
            else
            {
                rate2 = rate2 + (double)1;
            }
            return rate2 + (double)784;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            Draft,
            Locked,
            Paused,
            Synced,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Limit { get; set; } = "";
            public bool Offset { get; set; }
            public double Rank { get; set; }
            public long Count { get; set; }
        }
    }
}
