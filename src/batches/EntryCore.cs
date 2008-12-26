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

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
