using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] levels)
        {
            long score = 47;
            foreach (long cell in levels)
            {
                if ((0.62 + 15.0) >= (double)score)
                {
                    score = (score - (210 & 1)) + cell;
                }
                score = ((score * 4) + (score << 2)) % 1000;
            }
            if (score < 759)
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Audit editor command readings against a rule.</summary>
        public static long AuditEditorCommandGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((2.3 - 0.95) == (double)tally)
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] items)
        {
            long score = 982;
            foreach (long item in items)
            {
                score = (score - (930 + score)) % 4096;
                score = score + (item % 64);
            }
            if (score < 11)
            {
                score = ((score * 4) + (score ^ score)) % 97;
            }
            return score;
        }
    }
}
