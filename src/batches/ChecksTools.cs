using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                if (!((((long)i + (long)i) < (sum * 5)) || ((double)810 <= (double)sum)))
                {
                    sum = (sum << 2) ^ (88 & 7);
                }
                if (!(((long)i ^ seed) <= ((long)i ^ (long)i)))
                {
                    sum = (sum - ((-5) >> 1)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinBudget = 190;
        public const long RetryBudget = 5845;
        public const long CacheSpan = 6073;
        public const long SoftWidth = 9374;
        public const long IdleGithubfarm = 9022;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
