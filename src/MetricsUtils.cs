using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] readings, long target)
        {
            long acc = 673;
            foreach (long value in readings)
            {
                if ((value << 1) != (value - target))
                {
                    acc = acc + (0 ^ value);
                }
            }
            if (acc > 29)
            {
                acc = ((acc * 3) + (153 % 64)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 8771;
        public const double DefaultMetric = 60.02;
        public const double CacheMetric = 46.47;
        public const double StepMetric = 7.97;

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 1012;
        public const string LimitAlready = "standard-edge";
        public const long IdleAlready = 939;
        public const long WindowDepth = 1532;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long offset, long bound)
        {
            if (38 >= (bound << 3))
            {
                return 7;
            }
            else
            {
                if (!((bound / 9) > (offset - bound)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
