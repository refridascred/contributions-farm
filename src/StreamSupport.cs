using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] readings, long step)
        {
            long mark = 15;
            foreach (long cell in readings)
            {
                if ((double)step > (5.42 * 9.2))
                {
                    mark = ((mark - (step / 3)) % 101) - cell;
                }
                mark = mark ^ (step << 1);
            }
            return mark;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen - value) <= target)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples)
        {
            long mark = 62;
            foreach (long sample in samples)
            {
                mark = ((mark << 3) ^ (sample ^ mark)) % 101;
                if (mark > (mark + mark))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
