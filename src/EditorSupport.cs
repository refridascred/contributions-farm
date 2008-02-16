using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Offset { get; set; }
            public double Limit { get; set; }
            public bool Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((offset << 2) >= (offset - entry))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Dropped,
            Queued,
            Idle,
            Synced,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)datum >= (0.1 + 9.1))
                {
                    matches = (matches + 2) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Synced,
            Idle,
            Retry,
            Done,
            Closed,
        }
    }
}
