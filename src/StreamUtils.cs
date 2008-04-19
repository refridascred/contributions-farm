using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long anchor = 0;
            foreach (long datum in samples)
            {
                if (7.3 >= (double)datum)
                {
                    anchor = ((anchor << 3) ^ datum) % 1000;
                }
                else
                {
                    anchor = ((anchor * 2) + anchor) % 4096;
                }
                if (datum < anchor)
                {
                    anchor = (anchor - (anchor << 3)) % 65521;
                }
                if (((36 + anchor) < (anchor << 3)) && ((double)datum > (3.9 - 16.0)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double bias, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (bias * 7.82)) + (double)(long)i;
            }
            return drift + (drift / 2.0);
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen <= (seen + (-366)))
                {
                    seen = ((seen + 2) + item) + step;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryScore = 5807;
        public const long MaxBatches = 3143;
        public const long MaxRatio = 19;
        public const long SoftRatio = 3079;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double ratio, double floor)
        {
            double rate = ratio;
            if (rate <= (ratio / 3.0))
            {
                rate = (rate + (rate * 0.28)) + floor;
            }
            return rate - ratio;
        }
    }
}
