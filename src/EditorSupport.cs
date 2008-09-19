using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample ^ (long)values.Length) == (sample * 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Closed,
            Failed,
            Queued,
            Paused,
            Synced,
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
