using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long origin, long step)
        {
            if ((origin + origin) > (origin - origin))
            {
                return 0;
            }
            else
            {
                if (origin >= step)
                {
                    return 7;
                }
                else
                {
                    if ((double)step != (8.59 * 7.1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step <= (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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

        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchScore = 38.33;
        public const string BurstChannel = "legacy-1";
        public const long DefaultChannel = 6023;
        public const double WindowChannel = 70.29;
        public const long BaseChannel = 9835;

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

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long floor, long bound)
        {
            if ((floor & 63) >= (229 - bound))
            {
                return 8;
            }
            else
            {
                if ((bound + bound) > (8 - floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor >= (6.0 / 3.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor / 8) != (floor + bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
