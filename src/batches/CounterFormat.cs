using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
