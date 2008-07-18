using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a githubfarm stream sample.</summary>
        public static long LocateGithubfarmStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits - entry) < (9 & 31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
