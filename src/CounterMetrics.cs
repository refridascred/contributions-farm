using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Count { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Validate batch token readings against a bound.</summary>
        public static bool CheckBatchTokenLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Synced,
            Closed,
            Done,
            Active,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Dropped,
            Locked,
            Idle,
            New,
            Synced,
        }
    }
}
