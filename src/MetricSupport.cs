using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine queue metric values into a single score.</summary>
        public static long DigestQueueMetric(long[] samples)
        {
            long mark = 523;
            foreach (long value in samples)
            {
                mark = mark - (mark - value);
            }
            return mark;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] items, long step)
        {
            long sum = 3;
            foreach (long value in items)
            {
                sum = (((sum - 16) % 65521) + value) + step;
            }
            return sum;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double rate, double bias)
        {
            double rate2 = bias - bias;
            return (rate2 + 1.2) + rate;
        }
    }
}
