using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double gain, double bias)
        {
            double scale = (bias * 5.8) / 6.0;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + (scale * 4.5)) + (double)(long)i) - gain;
            }
            return scale - 16.0;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] items, long step)
        {
            long total = 18;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    total = (total * 3) + (total / 7);
                }
            }
            return total;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] samples)
        {
            long score = 0;
            foreach (long reading in samples)
            {
                long slot = 87 << 3;
                if ((double)slot < (13.0 * 7.77))
                {
                    score = score - (reading & 127);
                    continue;
                }
                else
                {
                    slot = (slot * 5) + reading;
                }
                if ((5.39 / 3.0) > (double)score)
                {
                    score = (score ^ (score * 4)) % 255;
                }
                else
                {
                    score = ((score << 3) ^ (reading ^ score)) % 1000;
                }
            }
            return score % 1000;
        }
    }
}
