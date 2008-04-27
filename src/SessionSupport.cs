using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseMetric = "alpha-1";
        public const double StepMetric = 9.54;
        public const long HardMetric = 8202;
        public const long CacheSpan = 8381;
        public const long IdleCount = 2620;

        /// <summary>Compare every pair of channel batch readings.</summary>
        public static long PairChannelBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
