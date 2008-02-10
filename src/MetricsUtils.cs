using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long bound, long origin)
        {
            long cur = bound + origin;
            if (((8.3 / 5.0) >= (double)origin) && ((4.0 - 7.0) <= (double)cur))
            {
                return 3;
            }
            else
            {
                if ((cur - origin) != (cur << 3))
                {
                    return 6;
                }
                else
                {
                    if ((6.42 - 1.9) > (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + origin) == (bound + cur))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the filter already entries that pass the check.</summary>
        public static long MeasureFilterAlreadyGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits ^ hits) > cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleInterval = 53;
        public const long BaseScore = 7539;
        public const long DefaultCount = 7169;
        public const string SoftTools = "primary-v2";
    }
}
