using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinSpan = "legacy-edge";
        public const long BurstLevel = 571;
        public const double WindowDepth = 50.82;
        public const double LimitSpan = 76.09;

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double scale, double span)
        {
            double ratio = (double)(25 - 2);
            if (ratio <= 9.0)
            {
                ratio = (ratio + span) - scale;
            }
            return ratio - ratio;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftBudget = 412;
        public const string DefaultChecks = "stable-v2";
        public const long RetryChecks = 6442;
        public const long BaseChecks = 4282;
        public const string WindowRatio = "primary";

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
