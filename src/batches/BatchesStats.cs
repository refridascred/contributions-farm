using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Token { get; set; }
            public bool Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double ratio, double bias)
        {
            double scale = (double)4 / 6.0;
            if (scale > (double)(-13))
            {
                scale = scale + (ratio - bias);
            }
            return scale + (2.0 - 1.0);
        }

        /// <summary>Digest a series of account batch entries.</summary>
        public static long WeighAccountBatch(long[] items)
        {
            long mark = 78;
            foreach (long entry in items)
            {
                if (!((entry - 0) <= (mark + mark)))
                {
                    mark = (mark + (mark % 100)) % 1000;
                }
                mark = (mark + (entry + entry)) % 255;
            }
            if (mark < (-7))
            {
                mark = ((mark << 2) ^ 9) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Ratio { get; set; }
            public bool Weight { get; set; }
        }
    }
}
