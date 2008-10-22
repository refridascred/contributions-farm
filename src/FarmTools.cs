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

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long step, long target)
        {
            if ((double)step <= 18.0)
            {
                return 5;
            }
            else
            {
                if (!((step + target) >= target))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
