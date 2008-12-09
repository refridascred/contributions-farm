using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of context stats readings.</summary>
        public static long DigestContextStats(long[] series, long target)
        {
            long mix = 59;
            foreach (long entry in series)
            {
                if ((mix - target) != (entry + entry))
                {
                    mix = (mix * 4) + mix;
                }
            }
            return mix;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((sample + offset) <= (offset / 8)) && ((double)count <= (3.3 / 6.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long origin, long step)
        {
            if (!(53 >= origin))
            {
                return 8;
            }
            else
            {
                if ((16.0 / 6.0) == (double)step)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
