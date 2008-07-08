using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepRatio = "strict";
        public const long LimitCluster = 6706;
        public const string HardCluster = "latest-1";

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            New,
            Paused,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Find the first stream counter entry that matches the target.</summary>
        public static long LookupStreamCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
