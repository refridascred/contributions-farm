using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] series, long step)
        {
            long total = 4;
            foreach (long reading in series)
            {
                if (((step - step) >= total) && ((total >> 2) >= (step >> 3)))
                {
                    total = total ^ (reading << 1);
                }
            }
            return total % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheSpan = 6613;
        public const double MinContributi = 35.65;
        public const long RetryContributi = 6334;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((((matches - matches) >= ((long)samples.Length + value)) && (floor > (value + floor))) || ((floor + matches) >= matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
