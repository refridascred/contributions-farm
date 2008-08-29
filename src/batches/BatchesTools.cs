using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((long)levels.Length * 3) < cell)
                {
                    tally = (tally + 3) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a editor batches value against two limits.</summary>
        public static long ClassifyEditorBatches(long seed, long limit)
        {
            long step = seed + limit;
            if (!((56 + step) >= (step + 16)))
            {
                return 6;
            }
            else
            {
                if ((double)seed == (double)step)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((tally + tally) < (794 * 2)) || (value <= (tally ^ offset)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
