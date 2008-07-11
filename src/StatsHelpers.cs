using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 7460;
        public const long SoftInterval = 3560;
        public const long BurstWidth = 1403;
        public const long HardGithubfarm = 5306;

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a token filter value against two limits.</summary>
        public static long BucketTokenFilter(long limit, long step)
        {
            if ((1 % 8) <= (limit / 2))
            {
                return 4;
            }
            else
            {
                if ((0.4 + 5.8) != (double)limit)
                {
                    return 5;
                }
                else
                {
                    if (((89 & 255) <= (limit ^ step)) && (limit <= (step - limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((5.32 + 0.6) < (double)limit) || ((limit + limit) == (limit * 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
