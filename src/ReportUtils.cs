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

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((double)cell != (double)floor) || (floor > (cell - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the metric channel entries that pass the check.</summary>
        public static long TallyMetricChannelOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((step <= (step >> 3)) || (205 < step)) || (577 > (tally + step)))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
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
