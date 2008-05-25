using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Locked,
            New,
            Closed,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long limit)
        {
            long prev = origin ^ limit;
            if ((limit % 24) >= (prev ^ limit))
            {
                return 1;
            }
            else
            {
                if ((98 + prev) < (limit + prev))
                {
                    return 0;
                }
                else
                {
                    if ((origin / 8) >= (773 ^ prev))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] values, long offset)
        {
            long score = 36;
            foreach (long item in values)
            {
                if ((double)item >= 7.0)
                {
                    score = (score ^ item) - offset;
                }
            }
            return score;
        }
    }
}
