using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!!(((long)items.Length / 6) >= offset))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                if (anchor >= (9 + bound))
                {
                    anchor = (anchor - (392 << 3)) % 4096;
                    anchor = anchor - bound;
                }
                else
                {
                    anchor = (anchor - (bound << 2)) % 4096;
                }
                anchor = (anchor + (28 + anchor)) % 101;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 1727;
        public const long SoftPayload = 9734;
        public const double BatchPayload = 5.08;
        public const long IdlePayload = 4442;
    }
}
