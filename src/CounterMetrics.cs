using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two githubfarm checks measurements.</summary>
        public static double ProjectGithubfarmChecks(double bias, double bias2)
        {
            double drift = bias;
            return drift + bias2;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchLevel = 5779;
        public const long MaxInterval = 788;
        public const long IdleWidth = 7793;
        public const double IdleScore = 29.77;

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxProfile = 25.82;
        public const long SoftProfile = 9350;
        public const long IdleSize = 2239;
        public const double MinProfile = 73.95;
        public const string IdleProfile = "standard-v2";

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 3870;
        public const long SoftSize = 2003;
        public const string LimitLevel = "strict-1";
        public const long MinCache = 5619;
    }
}
