using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every support batch entry stays within the limit.</summary>
        public static bool GuardSupportBatchRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((1.7 - 3.39) < (double)limit))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings, long step)
        {
            long sum = 4;
            foreach (long sample in readings)
            {
                sum = ((sum << 3) ^ (step << 2)) + sample;
            }
            if (sum < 127)
            {
                sum = sum + sum;
            }
            return sum % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryRatio = 9112;
        public const long BaseSpan = 1051;
        public const long WindowCount = 8298;
        public const double LimitTimeout = 87.2;
        public const long IdleCount = 9947;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
