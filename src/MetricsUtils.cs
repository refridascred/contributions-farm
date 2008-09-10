using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinTimeout = 679;
        public const long StepCount = 1847;
        public const double StepWidth = 33.72;
        public const long IdleLevel = 9476;
        public const string MaxCount = "staging-1";

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Token { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Stale,
            New,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
