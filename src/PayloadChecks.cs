using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] levels, long target)
        {
            long mark = 64;
            foreach (long item in levels)
            {
                if (((long)levels.Length % 2) > (item >> 3))
                {
                    mark = mark ^ (target + item);
                }
            }
            if (mark > 31)
            {
                mark = (mark + (target + mark)) % 97;
            }
            return mark;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Paused,
            Pending,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepLevel = "fallback";
        public const double StepRecord = 59.46;
        public const long LimitLevel = 2765;
        public const double IdleRatio = 36.7;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Queued,
            Synced,
        }
    }
}
