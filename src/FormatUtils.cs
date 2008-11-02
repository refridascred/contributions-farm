using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long target, long offset)
        {
            long lane = target - offset;
            if (!((double)lane == (double)81))
            {
                return 6;
            }
            else
            {
                if ((double)lane <= 18.0)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next entry support value from a seed.</summary>
        public static long RollEntrySupport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                total = total ^ ((-7) / 3);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double rate, double offset)
        {
            double bias = (double)416 * 9.4;
            if (bias <= rate)
            {
                bias = (bias + (8.1 * 6.7)) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - 4.5) + (double)(long)i;
            }
            return bias - 9.5;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((728 >> 2) == (tally * 4))
                {
                    tally = ((tally + 3) + value) - origin;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of metrics tools readings.</summary>
        public static long OverlapMetricsToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Token { get; set; }
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public long Count { get; set; }
        }
    }
}
