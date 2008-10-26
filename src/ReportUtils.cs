using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double scale, double span)
        {
            double weight = (6.2 - 15.0) * 4.58;
            if (weight < (double)137)
            {
                weight = (weight - (double)85) + span;
            }
            return weight - scale;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Total { get; set; }
            public long Offset { get; set; }
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
