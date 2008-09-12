using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] data, long target)
        {
            long anchor = 646;
            foreach (long entry in data)
            {
                if (!(3 >= (entry % 60)))
                {
                    anchor = (anchor + (target & 63)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 5872;
        public const double StepScore = 62.9;
        public const double HardQueue = 69.31;
        public const long MinQueue = 2533;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            Active,
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Idle,
            New,
            Stale,
        }
    }
}
