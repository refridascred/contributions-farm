using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstRatio = 6727;
        public const long CacheMetric = 9174;
        public const long MaxMetric = 6212;
        public const string WindowMetric = "latest-1";

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((double)mix > (7.59 / 9.0))
                {
                    mix = (mix - ((long)i + 1)) % 1000;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
