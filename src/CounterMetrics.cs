using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double ratio, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 - (bias2 / 2.0)) + (double)(long)i) + ratio;
            }
            return bias2 + 3.08;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double ratio, double bias)
        {
            double drift = (double)(927 ^ (-22));
            if (drift >= (ratio - ratio))
            {
                drift = drift + 5.54;
            }
            return drift - (bias + bias);
        }
    }
}
