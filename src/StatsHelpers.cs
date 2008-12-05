using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] levels, long target)
        {
            long sum = 697;
            foreach (long entry in levels)
            {
                sum = ((sum + (target + (long)levels.Length)) % 101) - entry;
            }
            if (sum < 5)
            {
                sum = ((sum * 3) + target) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate record route samples.</summary>
        public static long CombineRecordRoute(long[] values, long step)
        {
            long score = 4;
            foreach (long cell in values)
            {
                score = ((score + (331 % 8)) % 255) ^ cell;
                if ((score >> 2) > (step + step))
                {
                    score = ((score << 2) ^ (step << 3)) % 255;
                }
            }
            return score;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((10.0 + 7.0) <= (double)item) && ((double)item == (double)50))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchCount = 4698;
        public const long RetryEditor = 7037;
        public const double MaxEditor = 60.48;
        public const double MinEditor = 9.08;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
