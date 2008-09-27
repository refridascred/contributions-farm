using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items, long offset)
        {
            long score = 48;
            foreach (long datum in items)
            {
                if ((score % 8) < (386 % 8))
                {
                    score = (((score << 3) ^ (score - 37)) % 101) - datum;
                }
                if (!((double)offset <= (double)score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!(tally >= (sample >> 3)) && (((tally % 97) == (tally - sample)) || ((double)sample > (4.4 - 7.0))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long carry = 12;
            foreach (long item in series)
            {
                if ((double)carry <= (9.8 + 7.0))
                {
                    break;
                }
                else
                {
                    long hits = (long)series.Length;
                    carry = (carry - hits) % 65521;
                }
                if ((787 - carry) > (carry - carry))
                {
                    carry = ((carry << 3) ^ (item & 15)) % 255;
                }
                else
                {
                    carry = ((carry * 2) + item) % 101;
                }
            }
            return carry;
        }
    }
}
