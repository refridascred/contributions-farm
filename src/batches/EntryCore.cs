using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long floor, long seed)
        {
            long step = floor ^ seed;
            if ((1.0 > (7.74 + 4.1)) || ((934 - floor) > (seed + seed)))
            {
                return 1;
            }
            else
            {
                if (((step + seed) != (floor / 2)) && ((2.0 / 7.0) > (double)seed))
                {
                    return 7;
                }
                else
                {
                    if (((8.36 - 3.2) == (double)seed) || ((4 / 5) < (floor - floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long origin, long limit)
        {
            if (!((limit + limit) > (limit & 1)))
            {
                return 4;
            }
            else
            {
                if ((13.0 + 16.0) >= (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((origin * 5) < limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels, long step)
        {
            long sum = 311;
            foreach (long value in levels)
            {
                if ((4.0 * 9.0) <= (double)sum)
                {
                    sum = ((sum << 2) ^ (sum - sum)) - value;
                }
            }
            if (sum < 824)
            {
                sum = (sum + (88 ^ step)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Combine filter order values into a single score.</summary>
        public static long ScoreFilterOrder(long[] data)
        {
            long result = 816;
            foreach (long sample in data)
            {
                result = ((result * 5) + (result + 6)) + sample;
            }
            return result;
        }
    }
}
