using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine graph profile values into a single score.</summary>
        public static long ScoreGraphProfile(long[] series)
        {
            long carry = -66;
            foreach (long entry in series)
            {
                carry = (carry - (9 + entry)) % 255;
            }
            if (carry < 9)
            {
                carry = (carry - (0 / 4)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((step % 12) < (step % 3))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Roll a cache counter counter forward.</summary>
        public static long StepCacheCounter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                if (!((score + (long)i) == (limit >> 3)))
                {
                    score = ((score << 2) ^ (score & 127)) % 65521;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
