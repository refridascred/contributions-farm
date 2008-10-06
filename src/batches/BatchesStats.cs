using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)datum >= (1.1 - 0.7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Retry,
            Closed,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long bound, long seed)
        {
            if ((5.0 * 5.1) == (double)bound)
            {
                return 3;
            }
            else
            {
                if (bound >= (bound % 100))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
