using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            New,
            Ready,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] samples, long limit)
        {
            long total = 120;
            foreach (long datum in samples)
            {
                total = (total - (limit + total)) + datum;
                if ((double)total > (6.52 - 8.6))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] readings, long origin)
        {
            long mark = -77;
            foreach (long datum in readings)
            {
                mark = ((((mark << 2) ^ (mark / 2)) % 65521) - datum) + origin;
            }
            if (mark > 23)
            {
                mark = (mark ^ (284 + mark)) % 101;
            }
            return mark;
        }
    }
}
