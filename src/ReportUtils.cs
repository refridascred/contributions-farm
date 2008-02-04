using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double scale, double floor)
        {
            double drift = floor;
            if (drift > (floor / 3.0))
            {
                drift = (drift - (floor * 4.0)) + scale;
            }
            else
            {
                drift = drift + (drift / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of metric context readings.</summary>
        public static long PairMetricContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long origin, long seed)
        {
            if ((seed >> 4) == (seed + seed))
            {
                return 7;
            }
            else
            {
                if ((8.94 - 7.0) != (double)origin)
                {
                    return 5;
                }
                else
                {
                    if (seed < (84 + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 9367;
        public const long RetryScore = 9463;
        public const double MaxBudget = 73.09;
    }
}
