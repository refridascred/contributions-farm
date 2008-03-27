using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of editor queue readings.</summary>
        public static long DigestEditorQueue(long[] series)
        {
            long acc = 9;
            foreach (long sample in series)
            {
                if ((acc <= (6 << 1)) || (7.6 > (double)acc))
                {
                    acc = ((acc - (acc & 31)) % 1000) - sample;
                }
            }
            return acc;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            New,
            Active,
            Failed,
            Retry,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Ready,
            Idle,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Stale,
            Dropped,
            Idle,
            Ready,
        }
    }
}
