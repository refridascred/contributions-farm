using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Derive the next profile token value from a seed.</summary>
        public static long SeriesProfileToken(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                score = (score + ((long)i + 908)) % 65521;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftWidth = "primary";
        public const long IdleInterval = 5971;
        public const long BatchAlready = 6998;
        public const double HardAlready = 46.26;
    }
}
