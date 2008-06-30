using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] samples, long offset)
        {
            long anchor = 4;
            foreach (long value in samples)
            {
                anchor = ((anchor + (anchor + anchor)) % 255) + offset;
                if ((4 - value) < (anchor % 10))
                {
                    anchor = anchor ^ (value % 8);
                }
                else
                {
                    anchor = anchor ^ (anchor >> 3);
                }
                if ((7.0 + 8.9) < (double)value)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Stale,
            Closed,
            New,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
