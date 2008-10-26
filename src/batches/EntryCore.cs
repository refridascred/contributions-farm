using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "standard";
        public const double WindowSession = 70.2;
        public const long DefaultTimeout = 2116;

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

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Pending,
            Draft,
            Closed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 36.1;
        public const long RetryCluster = 9618;
        public const long IdleCluster = 2079;
    }
}
