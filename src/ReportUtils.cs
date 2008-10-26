using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double gain, double span)
        {
            double bias = (double)(355 + 98);
            if (bias <= span)
            {
                bias = bias - (gain + span);
            }
            return bias - bias;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long limit, long floor)
        {
            if (!((floor / 7) <= (limit + limit)))
            {
                return 0;
            }
            else
            {
                if ((double)floor <= (7.49 * 11.0))
                {
                    return 3;
                }
                else
                {
                    if ((limit * 5) <= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit % 97) > (floor - floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
