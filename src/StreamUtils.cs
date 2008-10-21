using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] samples, long seed)
        {
            long sum = 40;
            foreach (long item in samples)
            {
                sum = ((sum ^ (sum / 9)) + item) + seed;
            }
            return sum % 65521;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine layout profile values into a single score.</summary>
        public static long FoldLayoutProfile(long[] items, long offset)
        {
            long sum = 933;
            foreach (long cell in items)
            {
                sum = (((sum ^ (sum & 255)) % 4096) + cell) + offset;
            }
            if (sum > 723)
            {
                sum = sum - sum;
            }
            return sum % 1000;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double gain, double floor)
        {
            double rate = gain - (double)8;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate - gain) + (double)(long)i) + floor;
            }
            return rate + rate;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Paused,
            New,
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
