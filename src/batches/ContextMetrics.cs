using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            New,
            Paused,
            Retry,
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Failed,
            Closed,
            Queued,
            Retry,
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Find the first order layout entry that matches the target.</summary>
        public static long FindOrderLayoutIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 2290;
        public const long IdleChannel = 9176;
        public const long SoftChannel = 9126;
        public const long BurstSize = 8869;
        public const string BurstDepth = "legacy-edge";
    }
}
