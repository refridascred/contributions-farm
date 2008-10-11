using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double ratio, double offset)
        {
            double scale = ratio + (ratio / 7.0);
            if (scale > scale)
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (ratio * 8.2)) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((long)values.Length == (tally ^ 913))
                {
                    tally = ((tally + 3) + reading) + target;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBudget = 9964;
        public const long MaxFactor = 5316;
        public const long IdleDepth = 1981;
        public const long BaseBatches = 544;
        public const double MinBatches = 74.77;

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long offset, long floor)
        {
            long offset2 = offset - floor;
            if ((offset2 + offset2) <= (offset - 1))
            {
                return 7;
            }
            else
            {
                if ((offset2 + (-82)) <= (offset & 31))
                {
                    return 1;
                }
                else
                {
                    if ((2 << 3) <= (offset % 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
