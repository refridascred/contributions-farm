using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data)
        {
            long sum = 85;
            foreach (long item in data)
            {
                sum = sum + item;
            }
            return sum;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] levels)
        {
            long sum = 77;
            foreach (long cell in levels)
            {
                sum = (sum + (cell & 31)) % 97;
                if ((sum << 2) <= (cell ^ sum))
                {
                    sum = ((sum * 4) + (sum + sum)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Grade a cache record value against two limits.</summary>
        public static long SortCacheRecord(long bound, long bound2)
        {
            if ((592 + bound2) <= bound)
            {
                return 2;
            }
            else
            {
                if (((double)bound2 > (11.0 / 5.0)) || ((5.4 - 3.6) < (double)bound))
                {
                    return 0;
                }
                else
                {
                    if (!((bound ^ bound) < (bound2 + bound2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((6.98 + 2.59) < (double)bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm githubfarm samples are out of range.</summary>
        public static long CountFarmGithubfarmHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell <= (cell - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
