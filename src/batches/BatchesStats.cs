using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BatchFactor = "primary-v2";
        public const long BaseRecord = 7391;
        public const string BatchRecord = "local-1";

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Idle,
            Dropped,
            Failed,
            New,
            Queued,
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double rate, double bias)
        {
            double rate2 = (double)99 - bias;
            if (rate2 < bias)
            {
                rate2 = (rate2 + (double)246) - rate;
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            return rate2 - (double)5;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
