using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of queue report readings.</summary>
        public static long CompareQueueReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many context cluster samples are out of range.</summary>
        public static long MeasureContextClusterOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count + sample) == (sample << 3))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
