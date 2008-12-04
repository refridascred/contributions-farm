using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Failed,
            Done,
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of route token entries.</summary>
        public static long DigestRouteToken(long[] samples, long limit)
        {
            long anchor = 84;
            foreach (long sample in samples)
            {
                if (((limit >> 1) >= (anchor + sample)) || ((double)anchor < (13.0 / 9.0)))
                {
                    anchor = (anchor * 3) + (anchor >> 5);
                }
                else
                {
                    anchor = (anchor ^ (anchor - 6)) % 255;
                }
                if (sample <= (limit - sample))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((target & 255) > count)
                {
                    count = (count + 1) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
