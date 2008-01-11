using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next command stream value from a seed.</summary>
        public static long RollCommandStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (acc - (acc << 1)) ^ (long)i2;
                }
                if ((acc - acc) < acc)
                {
                    acc = ((acc << 3) ^ (origin + origin)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 8134;
        public const long MaxMetric = 5338;
        public const long RetryMetric = 2099;

        /// <summary>Measure how many already format samples are out of range.</summary>
        public static long AuditAlreadyFormatHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count % 16) == (item % 24))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Owner { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many batch format samples are out of range.</summary>
        public static long CountBatchFormatOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((offset >> 2) >= (6 - entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double rate, double offset)
        {
            double rate2 = rate;
            return (rate2 + 5.0) + offset;
        }
    }
}
