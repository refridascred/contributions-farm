using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)46 < (double)step)
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter account samples are out of range.</summary>
        public static long TallyCounterAccountOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((-27) >= (target - target))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Count farm session pairs that satisfy a relation.</summary>
        public static long OverlapFarmSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
