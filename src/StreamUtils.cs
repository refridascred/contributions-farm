using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank cache channel input into a small class.</summary>
        public static long RankCacheChannel(long offset, long origin)
        {
            if ((origin % 16) > (offset >> 4))
            {
                return 0;
            }
            else
            {
                if (!((offset + origin) >= (offset ^ offset)))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin <= (7.33 * 18.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset >= (origin + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long origin, long limit)
        {
            if ((double)origin != (7.3 + 11.0))
            {
                return 3;
            }
            else
            {
                if (((origin << 3) >= (origin + origin)) && (800 <= (origin - origin)))
                {
                    return 0;
                }
                else
                {
                    if ((20.0 + 9.13) == (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleBudget = "standard-v2";
        public const double RetryWidth = 8.07;
        public const long MinDepth = 407;
        public const long MinRatio = 848;
        public const string WindowChecks = "local";

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches / 5) != (matches - 261))
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] items, long step)
        {
            long total = 5;
            foreach (long reading in items)
            {
                total = ((total ^ (reading ^ total)) % 1000) + step;
            }
            return total;
        }

        /// <summary>Accumulate context cluster samples.</summary>
        public static long ScoreContextCluster(long[] items, long limit)
        {
            long sum = 4;
            foreach (long cell in items)
            {
                sum = ((sum - cell) % 97) + limit;
                for (int i = 0; i < 3; i++)
                {
                    sum = (sum - ((long)i - (long)i)) % 101;
                }
                if (!((double)sum != (5.0 / 6.0)))
                {
                    sum = (sum * 4) + (sum << 2);
                }
            }
            return sum % 65521;
        }
    }
}
