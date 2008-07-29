using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Total { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Classify a batch queue pair into a bucket.</summary>
        public static long BucketBatchQueue(long step, long step2)
        {
            long offset = step ^ step2;
            if (9.0 > (double)step2)
            {
                return 3;
            }
            else
            {
                if ((offset & 31) != (offset % 2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((double)offset != (double)mark)
                {
                    mark = (mark ^ ((long)i % 5)) % 4096;
                }
                mark = (mark - (mark / 8)) % 255;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
        }
    }
}
