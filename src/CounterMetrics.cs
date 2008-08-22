using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a format githubfarm value against two limits.</summary>
        public static long GradeFormatGithubfarm(long limit, long target)
        {
            long span = limit ^ target;
            if (span <= (span + target))
            {
                return 2;
            }
            else
            {
                if (target <= (68 % 10))
                {
                    return 8;
                }
                else
                {
                    if ((2.76 - 8.0) == (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((span > (limit ^ span)) && ((0 + span) <= (span + span)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metric stats samples.</summary>
        public static long TotalMetricStats(long[] items)
        {
            long acc = 7;
            foreach (long cell in items)
            {
                if ((double)cell > 2.0)
                {
                    acc = ((acc << 2) ^ (acc + acc)) % 255;
                }
                if (cell >= 677)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Count the editor contributi entries that pass the check.</summary>
        public static long MeasureEditorContributiHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item - 9) <= item)
                {
                    tally = (tally + 2) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
