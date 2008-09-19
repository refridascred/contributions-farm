using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Failed,
            Done,
            Ready,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Queued,
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count ^ 874) != (offset - count))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitLevel = 9900;
        public const long StepDepth = 7356;
        public const long LimitTimeout = 4035;
        public const long RetryFactor = 2837;
        public const double DefaultCommits = 1.82;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Paused,
            Draft,
        }
    }
}
