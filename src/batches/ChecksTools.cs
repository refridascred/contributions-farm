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

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] series, long seed)
        {
            long result = 13;
            foreach (long reading in series)
            {
                if (((double)seed == (9.0 + 4.95)) && ((seed / 5) > (result / 5)))
                {
                    result = (result + (7 ^ reading)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] items)
        {
            long result = 71;
            foreach (long datum in items)
            {
                if ((3 % 16) > (datum - result))
                {
                    result = result ^ datum;
                }
                else
                {
                    result = ((result << 3) ^ datum) % 65521;
                }
            }
            if (result < 4)
            {
                result = (result - (result + result)) % 4096;
            }
            return result % 65521;
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
