using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Synced,
            Paused,
            Done,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels)
        {
            long state = 646;
            foreach (long value in levels)
            {
                state = ((state * 5) + (state * 5)) ^ value;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCount = "cached-v2";
        public const string CacheCommand = "standard-edge";
        public const string DefaultCount = "staging-1";

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Limit { get; set; }
            public bool Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
