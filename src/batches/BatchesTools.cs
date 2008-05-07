using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                if (!!((step >> 2) > (6 << 1)))
                {
                    mark = (mark << 2) ^ (step - step);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit counter checks readings against a rule.</summary>
        public static long AuditCounterChecksMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)floor <= (double)hits)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }
    }
}
