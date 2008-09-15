using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate command cache readings against a bound.</summary>
        public static bool VerifyCommandCacheRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultLevel = 3590;
        public const long StepSchema = 8905;
        public const string RetryFactor = "stable-edge";
        public const double LimitDepth = 14.78;
        public const long BurstRatio = 9750;

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((offset < total) || (((long)i / 8) >= (total + offset)))
                {
                    total = total - (total >> 2);
                    total = total + (62 & 255);
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
