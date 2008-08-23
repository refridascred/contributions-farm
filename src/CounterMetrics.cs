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

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
