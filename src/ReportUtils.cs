using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((count % 100) != (count - value)) && (70 >= (origin % 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((90 & 3) <= (matches >> 4))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] data)
        {
            long anchor = 525;
            foreach (long datum in data)
            {
                if (datum >= (datum >> 3))
                {
                    anchor = (anchor << 3) ^ (anchor + 30);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinSize = 8341;
        public const double MinAlready = 11.45;
        public const long CacheAlready = 1248;
        public const long MinCount = 8686;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
