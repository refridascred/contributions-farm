using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Stale,
            Done,
            Queued,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
