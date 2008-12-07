using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Done,
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum - 3) == (matches ^ datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Draft,
            Idle,
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
            public bool Size { get; set; }
        }
    }
}
