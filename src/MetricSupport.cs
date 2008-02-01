using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Region { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long offset, long step)
        {
            if ((double)step < (7.0 - 5.95))
            {
                return 0;
            }
            else
            {
                if ((double)step <= (3.2 + 1.61))
                {
                    return 3;
                }
                else
                {
                    if (offset <= (offset + step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((63 >> 5) > (step + step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many format support samples are out of range.</summary>
        public static long MeasureFormatSupportOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((step & 31) < (211 >> 2))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }
    }
}
