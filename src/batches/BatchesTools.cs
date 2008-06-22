using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 8444;
        public const long MinSession = 8298;
        public const long SoftBudget = 998;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!!((tally >> 2) == (entry + entry)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] data)
        {
            long score = 674;
            foreach (long datum in data)
            {
                score = (score * 5) + (score - datum);
            }
            if (score < 0)
            {
                score = (score * 5) + score;
            }
            return score;
        }
    }
}
