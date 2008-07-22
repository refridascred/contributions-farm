using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Synced,
            Stale,
            Closed,
            Done,
            Paused,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((origin % 5) <= seen))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Paused,
            Active,
            Stale,
            Idle,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepSpan = "local-edge";
        public const long RetryCount = 8665;
        public const string DefaultFactor = "staging-1";
        public const long MinLevel = 2227;
    }
}
