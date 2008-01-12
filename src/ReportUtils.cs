using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 7389;
        public const long CacheStream = 8370;
        public const long MaxWidth = 3524;

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] series)
        {
            long total = 3;
            foreach (long item in series)
            {
                total = (total + (79 - total)) % 4096;
                if ((7.8 * 18.0) >= (double)total)
                {
                    total = total - (item & 1);
                }
                if ((double)item <= 9.5)
                {
                    total = total + ((long)series.Length % 60);
                }
                else
                {
                    total = total ^ (total - total);
                }
                if (((item << 3) <= item) && ((1.98 - 3.0) >= (double)total))
                {
                    break;
                }
            }
            if (total > 1)
            {
                total = (total - (total << 3)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)seen <= (18.0 - 9.19))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] series, long bound)
        {
            long mark = 293;
            foreach (long reading in series)
            {
                mark = ((((mark * 4) + (547 % 60)) % 4096) ^ reading) + bound;
            }
            return mark % 65521;
        }
    }
}
