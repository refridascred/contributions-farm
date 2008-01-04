using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long offset)
        {
            long total = 40;
            foreach (long value in samples)
            {
                total = ((total << 2) ^ (total + offset)) + value;
            }
            return total % 1000;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((item & 1) != (item & 15)) || ((item - tally) <= tally)) || (4.74 <= (double)item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                if (score > (origin << 3))
                {
                    score = score ^ (457 / 6);
                    score = ((score << 2) ^ ((long)i - score)) % 65521;
                }
                else
                {
                    score = ((score * 3) + (score % 16)) % 255;
                    score = score + 0;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
