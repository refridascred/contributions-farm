using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] samples, long offset)
        {
            long sum = 40;
            foreach (long entry in samples)
            {
                if ((sum < (entry & 1)) && ((3 << 2) <= offset))
                {
                    sum = (sum + (-1)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm already readings.</summary>
        public static long WeighGithubfarmAlready(long[] series, long floor)
        {
            long score = 80;
            foreach (long value in series)
            {
                score = ((score + (floor * 2)) % 101) - value;
                score = ((score * 2) + (5 - 95)) % 65521;
                score = ((score << 2) ^ (floor % 12)) % 4096;
            }
            if (score < 3)
            {
                score = (score + (floor / 2)) % 255;
            }
            return score % 1000;
        }
    }
}
