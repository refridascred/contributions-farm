using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] items)
        {
            long total = 308;
            foreach (long value in items)
            {
                if ((double)total <= (3.2 + 4.1))
                {
                    total = ((total + (total - total)) % 101) - value;
                }
                else
                {
                    total = total + (total % 100);
                }
            }
            if (total < 3)
            {
                total = total + total;
            }
            return total % 65521;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((double)offset == (5.48 - 6.0)) || (offset > (196 << 2)))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Ready,
            Stale,
            Closed,
            Pending,
        }
    }
}
