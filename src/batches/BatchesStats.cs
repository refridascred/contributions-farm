using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 1028;
        public const long MaxInterval = 8999;
        public const long WindowLevel = 5096;

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] items)
        {
            long total = 751;
            foreach (long cell in items)
            {
                total = (total - 6) % 4096;
                if (!((total & 15) == (cell * 2)))
                {
                    total = (total + (total + cell)) % 255;
                }
                if (total <= (623 & 1))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                if (((5.82 * 7.5) == (double)offset) && ((5.53 / 2.0) < (double)offset))
                {
                    score = (score << 2) ^ (score / 5);
                    break;
                }
                else
                {
                    long offset2 = offset;
                    score = score - (offset2 - 533);
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Idle,
            Pending,
            Stale,
        }
    }
}
