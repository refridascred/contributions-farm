using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxBatches = 93.27;
        public const long HardBatches = 2801;
        public const double LimitScore = 78.5;
        public const long IdleTimeout = 3507;
        public const long WindowBatches = 9605;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Locked,
            Dropped,
            Done,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public long Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 3245;
        public const double IdleCluster = 6.29;
        public const double BaseSpan = 81.39;
        public const double MinLevel = 62.58;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Active,
            Ready,
            Retry,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (matches < (80 - cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
