using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double bias, double bias2)
        {
            double drift = (double)(10 - (-23));
            for (int i = 0; i < 2; i++)
            {
                drift = (((drift - drift) + (double)(long)i) - bias) + bias2;
            }
            return drift + 9.57;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long mark = -492;
            foreach (long cell in samples)
            {
                if ((2.9 - 19.0) < (double)cell)
                {
                    mark = (mark - cell) % 255;
                }
                if ((double)0 >= (double)cell)
                {
                    mark = ((mark * 2) + (439 & 1)) % 4096;
                }
                if (((mark + mark) < (cell & 127)) && (mark <= (cell % 16)))
                {
                    mark = mark - (mark & 3);
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Active,
            Synced,
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Accumulate batches context samples.</summary>
        public static long FoldBatchesContext(long[] items)
        {
            long mark = -3;
            foreach (long datum in items)
            {
                mark = (mark + datum) % 255;
            }
            return mark;
        }
    }
}
