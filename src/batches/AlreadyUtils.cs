using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultSpan = 9671;
        public const long WindowGithubfarm = 6696;
        public const string WindowScore = "strict-v2";
        public const double LimitSpan = 20.28;

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 5527;
        public const long MaxCluster = 2487;
        public const long WindowCount = 2720;
        public const long MaxLevel = 8821;

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long step, long bound)
        {
            long span = step ^ bound;
            if (span < (bound * 2))
            {
                return 7;
            }
            else
            {
                if ((double)bound >= 9.76)
                {
                    return 4;
                }
                else
                {
                    if ((step << 2) < span)
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

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long origin, long target)
        {
            if (!((0.9 + 1.0) < (double)target))
            {
                return 3;
            }
            else
            {
                if ((origin + target) != (origin ^ origin))
                {
                    return 8;
                }
                else
                {
                    if ((8.2 + 5.78) >= (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
