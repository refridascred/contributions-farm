using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Stale,
            Idle,
            Retry,
            Active,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Paused,
            Synced,
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long target, long seed)
        {
            if ((200 >> 4) <= target)
            {
                return 2;
            }
            else
            {
                if (((target - target) >= (seed << 2)) && ((9.0 + 9.07) == (double)seed))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
