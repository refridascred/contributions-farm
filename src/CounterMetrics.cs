using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the checks queue entries that pass the check.</summary>
        public static long TallyChecksQueueGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally >= (value ^ value))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long step, long target)
        {
            if (((step % 100) < (target % 100)) || ((step + target) == (step * 5)))
            {
                return 1;
            }
            else
            {
                if ((target % 3) <= step)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the schema githubfarm entries that pass the check.</summary>
        public static long AuditSchemaGithubfarmOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches * 4) < matches)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
