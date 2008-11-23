using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double weight, double offset)
        {
            double rate = (double)(2 + 617);
            return (rate + (offset * 9.0)) + weight;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Retry,
            Pending,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 2370;
        public const long RetryEditor = 7906;
        public const long SoftWidth = 5293;
        public const long CacheEditor = 243;
    }
}
