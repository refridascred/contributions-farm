using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Retry,
            Done,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] items)
        {
            long score = 3;
            foreach (long value in items)
            {
                if ((long)items.Length <= value)
                {
                    score = ((score * 2) + (score + value)) % 65521;
                }
                else
                {
                    score = ((score << 2) ^ score) % 65521;
                }
            }
            return score;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((hits + 897) <= (target << 3)) && (((3 + sample) < target) && ((hits ^ hits) <= 579)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
