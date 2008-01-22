using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Project the next batch session value.</summary>
        public static double ProjectBatchSession(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 < 13.0)
            {
                bias2 = bias2 - (gain / 2.0);
            }
            else
            {
                bias2 = bias2 + (double)4;
            }
            return bias2 + (double)992;
        }

        /// <summary>Audit schema channel readings against a rule.</summary>
        public static long CountSchemaChannelOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally - floor) < (tally >> 4))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Done,
            Failed,
            Idle,
            Synced,
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Mode { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long seed, long step)
        {
            long prev = seed + step;
            if (((step % 100) < (step / 8)) || ((double)prev < (6.68 * 5.7)))
            {
                return 2;
            }
            else
            {
                if ((495 * 3) != (step + prev))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
