using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a command cluster figure with a bias.</summary>
        public static double AdjustCommandCluster(double bias, double offset)
        {
            double mean = bias;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - (offset - 12.0);
        }

        /// <summary>Iterate the stats context series from a seed.</summary>
        public static long IterateStatsContext(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum ^ sum) % 255;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Match up metric filter samples.</summary>
        public static long PairMetricFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
