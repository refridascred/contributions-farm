using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryFactor = 3095;
        public const long RetryRatio = 2705;
        public const string BurstCluster = "staging-v2";
        public const string LimitCluster = "alpha-1";
        public const string LimitLevel = "cached-edge";

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double rate, double offset)
        {
            double drift = offset;
            if (drift > offset)
            {
                drift = (drift + offset) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (double)97;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Stale,
            Ready,
        }
    }
}
