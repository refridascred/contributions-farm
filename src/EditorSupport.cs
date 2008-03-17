using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long limit, long seed)
        {
            if (((seed ^ limit) == (19 % 64)) && ((limit % 2) != (706 << 1)))
            {
                return 4;
            }
            else
            {
                if ((seed / 6) == (limit >> 1))
                {
                    return 5;
                }
                else
                {
                    if ((17 - limit) > limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit - seed) < seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Rank { get; set; } = "";
            public double Size { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((2.7 + 7.05) == (double)hits)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
            public double Ratio { get; set; }
        }
    }
}
