using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double gain, double bias)
        {
            double rate = gain;
            if (rate <= rate)
            {
                rate = (rate + gain) - bias;
            }
            return rate - (double)9;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheSize = "staging-edge";
        public const double IdleCommits = 41.14;
        public const long BatchCommits = 1736;
    }
}
