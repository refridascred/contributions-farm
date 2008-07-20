using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 38.14;
        public const long WindowCommand = 1436;
        public const double SoftCount = 55.27;
        public const long RetryRatio = 3021;

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of profile commits readings.</summary>
        public static long CompareProfileCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] levels, long floor)
        {
            long result = 7;
            foreach (long item in levels)
            {
                result = (((result << 2) ^ item) % 65521) - floor;
            }
            return result % 1000;
        }
    }
}
