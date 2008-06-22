using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
            public string Owner { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally < (94 * 2)) || ((18.0 * 7.51) >= (double)datum))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long mix = -82;
            foreach (long cell in levels)
            {
                mix = ((mix * 5) + (mix / 9)) - cell;
            }
            return mix % 65521;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Owner { get; set; } = "";
            public double Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long bound, long floor)
        {
            long edge = bound - floor;
            if (((double)edge < (7.0 * 3.0)) && ((floor - edge) >= 186))
            {
                return 3;
            }
            else
            {
                if (((7.01 + 8.0) < (double)bound) || ((9 * 4) != (floor + edge)))
                {
                    return 1;
                }
                else
                {
                    if ((edge * 2) < (bound - 124))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
