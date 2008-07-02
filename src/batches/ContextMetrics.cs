using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long limit, long offset)
        {
            if (offset < limit)
            {
                return 7;
            }
            else
            {
                if ((8.5 + 13.0) == (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((781 + limit) < (limit % 100))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((5.1 + 8.8) >= (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell > tally) || (tally <= (92 << 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long result = 37;
            foreach (long value in series)
            {
                if (((result - result) != (value + result)) || ((result ^ (long)series.Length) < (value / 5)))
                {
                    result = ((result * 4) + (6 % 7)) % 97;
                }
            }
            if (result < 376)
            {
                result = (result + (result - result)) % 97;
            }
            return result;
        }
    }
}
