using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of cluster commits readings.</summary>
        public static long MatchClusterCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Dropped,
            Idle,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Locked,
            Paused,
            Failed,
            Dropped,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Retry,
            Locked,
            Done,
            Ready,
            New,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftScore = "staging";
        public const long BaseWidth = 982;
        public const long HardRoute = 1754;
    }
}
