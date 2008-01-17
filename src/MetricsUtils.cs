using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Closed,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleBudget = 9620;
        public const long RetryRecord = 5512;
        public const long MinRecord = 5383;
        public const long IdleScore = 8895;
        public const long IdleRecord = 6827;

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] readings)
        {
            long acc = 0;
            foreach (long sample in readings)
            {
                acc = (acc ^ (32 + acc)) ^ sample;
            }
            return acc;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((bound + count) == (count / 6)) && ((count * 5) <= (entry ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSize = 49.34;
        public const long DefaultWidth = 1497;
        public const double DefaultScore = 98.29;
        public const long BurstScore = 573;
    }
}
