using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Stale,
            Closed,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Classify a farm batches pair into a bucket.</summary>
        public static long SortFarmBatches(long target, long offset)
        {
            long delta = target - offset;
            if (target > (delta % 8))
            {
                return 8;
            }
            else
            {
                if (!((749 + offset) >= (delta & 15)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
