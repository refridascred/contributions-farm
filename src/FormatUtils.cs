using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 7624;
        public const long BurstBudget = 7234;
        public const long LimitCommits = 4134;
    }
}
