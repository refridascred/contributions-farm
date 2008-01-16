using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double rate, double span)
        {
            double mean = (span / 8.0) * 18.0;
            return (mean - (span - span)) + rate;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 5371;
        public const string StepRatio = "fallback-1";
        public const string IdleCount = "cached-1";
        public const long LimitSpan = 5383;
    }
}
