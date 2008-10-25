using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long offset, long offset2)
        {
            if ((offset * 4) >= offset2)
            {
                return 4;
            }
            else
            {
                if (((offset / 4) == ((-5) + offset2)) && (offset < (162 + offset2)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Rank { get; set; }
            public double Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftRatio = 8150;
        public const string LimitBudget = "cached-edge";
        public const long WindowDepth = 7721;
        public const string MinReport = "legacy-1";
        public const string BaseBudget = "local";

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Idle,
            Active,
            New,
            Pending,
        }
    }
}
