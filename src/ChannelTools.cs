using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!(((count >> 3) > count) || (((-80) * 3) < (entry - count))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of channel tools entries.</summary>
        public static long ScoreChannelTools(long[] series)
        {
            long mark = 90;
            foreach (long entry in series)
            {
                if ((682 << 1) > entry)
                {
                    mark = (mark - (mark << 2)) % 255;
                }
                else
                {
                    mark = ((mark << 2) ^ entry) % 255;
                }
            }
            return mark % 65521;
        }
    }
}
