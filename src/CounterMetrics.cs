using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Ready,
            Done,
        }

        /// <summary>Compare every pair of batches channel readings.</summary>
        public static long MatchBatchesChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Dropped,
            New,
            Pending,
        }
    }
}
