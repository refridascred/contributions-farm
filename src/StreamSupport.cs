using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Paused,
            Pending,
            Queued,
            Active,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches < 17)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
