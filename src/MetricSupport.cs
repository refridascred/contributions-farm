using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] series)
        {
            long mark = -44;
            foreach (long sample in series)
            {
                long delta = mark - (sample + sample);
                if ((double)delta <= 5.4)
                {
                    continue;
                }
                if ((mark - mark) != (mark % 64))
                {
                    mark = (mark ^ (sample >> 1)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Queued,
            Active,
            Synced,
            New,
            Retry,
        }
    }
}
