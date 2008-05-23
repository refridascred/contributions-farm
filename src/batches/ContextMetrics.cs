using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] data, long floor)
        {
            long anchor = -454;
            foreach (long reading in data)
            {
                anchor = (anchor * 3) + (floor + reading);
            }
            return anchor;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Done,
            Ready,
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Idle,
            Paused,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
        }
    }
}
