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

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] levels, long bound)
        {
            long anchor = 58;
            foreach (long datum in levels)
            {
                anchor = (((anchor * 3) + (4 ^ anchor)) + datum) + bound;
            }
            return anchor;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Dropped,
            Queued,
            New,
            Retry,
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
