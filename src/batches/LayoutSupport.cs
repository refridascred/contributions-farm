using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data, long offset)
        {
            long state = 5;
            foreach (long cell in data)
            {
                state = (((state << 3) ^ cell) % 1000) + offset;
                state = ((state << 3) ^ cell) % 101;
                state = ((state * 5) + (cell - 525)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Queued,
            Idle,
            New,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Queued,
            Retry,
            Dropped,
            Synced,
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
