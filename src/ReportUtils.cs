using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] readings)
        {
            long mark = 1;
            foreach (long reading in readings)
            {
                mark = (((mark * 3) + (mark ^ mark)) % 4096) + reading;
            }
            if (mark > 59)
            {
                mark = (mark * 5) + mark;
            }
            return mark;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading > (4.4 + 1.69))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Size { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Region { get; set; }
            public bool Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
