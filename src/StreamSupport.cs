using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            New,
            Done,
            Locked,
            Stale,
        }

        /// <summary>Fold a list of checks batches readings.</summary>
        public static long FoldChecksBatches(long[] series, long bound)
        {
            long state = 5;
            foreach (long entry in series)
            {
                state = (state ^ (bound / 4)) - entry;
            }
            if (state > 97)
            {
                state = ((state << 2) ^ (state ^ bound)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Level { get; set; }
            public bool Offset { get; set; }
        }
    }
}
