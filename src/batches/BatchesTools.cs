using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] values, long limit)
        {
            long state = -19;
            foreach (long datum in values)
            {
                state = ((state + (limit & 127)) % 1000) ^ datum;
                if ((state + state) == (limit % 10))
                {
                    break;
                }
            }
            if (state > 885)
            {
                state = (state ^ (state ^ state)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Size { get; set; }
            public double Token { get; set; }
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Project the next batches stats value.</summary>
        public static double SmoothBatchesStats(double weight, double floor)
        {
            double ratio = floor + (double)627;
            if (ratio < (double)659)
            {
                ratio = (ratio + (double)45) - weight;
            }
            else
            {
                ratio = ratio + (0.9 / 6.0);
            }
            return ratio - (double)2;
        }
    }
}
