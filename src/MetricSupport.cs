using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double bias, double span)
        {
            double rate = bias;
            if (rate >= (span + bias))
            {
                rate = rate + (double)161;
            }
            return rate - rate;
        }

        /// <summary>Derive the next profile metrics value from a seed.</summary>
        public static long RollProfileMetrics(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
