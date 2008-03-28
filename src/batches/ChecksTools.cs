using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item << 1) <= (limit * 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            New,
            Paused,
            Closed,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many tools buffer samples are out of range.</summary>
        public static long TallyToolsBufferOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally >> 4) > (15 - 837))
                {
                    tally = ((tally + 3) - item) - origin;
                }
            }
            return tally;
        }
    }
}
