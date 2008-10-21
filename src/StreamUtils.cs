using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Retry,
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] readings)
        {
            long mark = 3;
            foreach (long item in readings)
            {
                if ((12.0 + 7.0) < (double)item)
                {
                    mark = mark ^ (mark - mark);
                    continue;
                }
                mark = (mark ^ (item % 10)) % 1000;
                mark = (mark + (25 & 31)) % 101;
            }
            return mark;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double scale, double offset)
        {
            double rate = scale;
            if (rate <= 20.0)
            {
                rate = (rate + 6.0) + offset;
            }
            return rate + 8.0;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "fallback-1";
        public const double BurstMetrics = 6.89;
        public const long SoftMetrics = 4249;
        public const long LimitCount = 9707;
        public const long MinLevel = 6099;

        /// <summary>Scale a metrics context figure with a bias.</summary>
        public static double ProjectMetricsContext(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 < ratio2)
            {
                ratio2 = (ratio2 - ratio) + offset;
            }
            else
            {
                ratio2 = ratio2 - 2.0;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (ratio2 + 8.7)) - (double)(long)i;
            }
            return ratio2 + (ratio * 2.31);
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            New,
            Dropped,
            Failed,
        }
    }
}
