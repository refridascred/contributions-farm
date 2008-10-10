using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (0.8 >= (double)floor)
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] items)
        {
            long sum = 8;
            foreach (long datum in items)
            {
                if ((sum * 4) < sum)
                {
                    sum = ((sum * 4) + (sum & 15)) + datum;
                }
            }
            if (sum < 6)
            {
                sum = (sum + sum) % 255;
            }
            return sum % 97;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long floor, long target)
        {
            long cur = floor ^ target;
            if ((target >> 3) <= 8)
            {
                return 2;
            }
            else
            {
                if (!((floor + floor) != (897 - floor)))
                {
                    return 4;
                }
                else
                {
                    if ((target <= floor) || ((double)cur == (6.17 + 4.5)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Retry,
            Synced,
            Idle,
            Closed,
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double bias, double floor)
        {
            double rate = bias;
            if (rate >= rate)
            {
                rate = (rate + 1.1) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (2.0 - 2.29);
        }
    }
}
