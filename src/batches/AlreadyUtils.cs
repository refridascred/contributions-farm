using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many payload session samples are out of range.</summary>
        public static long CountPayloadSessionOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits >> 2) < (datum * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two order stream measurements.</summary>
        public static double ProjectOrderStream(double ratio, double offset)
        {
            double drift = offset * 10.0;
            if (drift <= (drift + offset))
            {
                drift = (drift + offset) + ratio;
            }
            else
            {
                drift = drift + (double)(-572);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - 1.0) + (double)(long)i;
            }
            return drift + (double)491;
        }

        /// <summary>Count the metrics already entries that pass the check.</summary>
        public static long MeasureMetricsAlreadyOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample - bound) < sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the checks entry series from a seed.</summary>
        public static long IterateChecksEntry(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (((anchor * 4) + anchor) % 97) + (long)i2;
                }
                if (((-452) & 31) > limit)
                {
                    anchor = (anchor ^ anchor) % 4096;
                }
                anchor = anchor ^ ((-31) * 3);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 6188;
        public const long RetryScore = 4367;
        public const long StepBatches = 9121;
        public const string CacheRatio = "strict-v2";
    }
}
