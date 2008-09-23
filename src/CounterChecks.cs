using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item % 7) != (seen + item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] readings)
        {
            long sum = 9;
            foreach (long item in readings)
            {
                if ((double)sum < (19.0 / 4.0))
                {
                    sum = ((sum << 3) ^ (item * 5)) % 65521;
                }
            }
            if (sum < (-146))
            {
                sum = sum ^ (sum - sum);
            }
            return sum;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] levels, long floor)
        {
            long score = 4;
            foreach (long entry in levels)
            {
                score = ((score << 3) ^ (score * 5)) % 1000;
                if ((957 + floor) <= (score + entry))
                {
                    score = ((score << 2) ^ (entry / 6)) % 1000;
                }
                else
                {
                    score = ((score * 3) + (654 + score)) % 65521;
                    score = (score << 3) ^ entry;
                }
                if ((7 - score) < (score - entry))
                {
                    score = score - (score ^ 7);
                }
                else
                {
                    score = score - (entry ^ entry);
                }
                if (entry < (2 - score))
                {
                    break;
                }
            }
            if (score < 10)
            {
                score = (score - (floor & 1)) % 255;
            }
            return score;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
