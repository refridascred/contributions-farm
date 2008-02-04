using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardDepth = 2978;
        public const long IdleMetric = 1094;
        public const long StepBudget = 5811;
        public const string WindowMetric = "alpha-v2";

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 239;
        public const long HardEntry = 5321;
        public const double RetryScore = 59.03;
        public const long StepEntry = 5919;
        public const long MinCount = 5500;

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Pending,
            Closed,
            Failed,
            Stale,
        }
    }
}
