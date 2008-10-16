using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Paused,
            Idle,
            Retry,
            Draft,
            Active,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] items)
        {
            long mark = 8;
            foreach (long value in items)
            {
                if ((3.04 + 4.3) == (double)value)
                {
                    mark = (mark - (mark % 97)) % 4096;
                }
                else
                {
                    mark = (mark ^ (mark + mark)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell >= (count ^ 25))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many channel schema samples are out of range.</summary>
        public static long AuditChannelSchemaOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum - count) == (count >> 4))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }
    }
}
