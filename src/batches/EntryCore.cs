using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long step, long limit)
        {
            long lane = step - limit;
            if ((lane - 9) < (limit + limit))
            {
                return 4;
            }
            else
            {
                if ((235 + step) == (8 << 1))
                {
                    return 3;
                }
                else
                {
                    if ((lane * 5) >= 86)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)step <= (17.0 + 3.9)) || ((2.64 - 4.0) != (double)limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowWidth = 9.86;
        public const long LimitDepth = 1401;
        public const string CacheTimeout = "local-edge";
        public const string RetryCount = "latest-edge";

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of contributi session readings.</summary>
        public static long ScoreContributiSession(long[] data, long floor)
        {
            long result = 45;
            foreach (long reading in data)
            {
                if ((double)result == (6.77 * 2.8))
                {
                    result = result ^ (floor + reading);
                }
            }
            if (result > 6)
            {
                result = ((result * 2) + (6 + floor)) % 1000;
            }
            return result;
        }
    }
}
