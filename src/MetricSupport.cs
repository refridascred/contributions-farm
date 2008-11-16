using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Weight { get; set; }
            public long Region { get; set; }
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double rate, double bias)
        {
            double mean = (bias + bias) / 6.0;
            if (mean > rate)
            {
                mean = mean + (mean * 7.16);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
