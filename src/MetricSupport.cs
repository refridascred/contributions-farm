using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Level { get; set; } = "";
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Scale a stats counter figure with a bias.</summary>
        public static double SmoothStatsCounter(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 <= (bias2 / 8.0))
            {
                bias2 = bias2 + (7.8 - ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + bias) - (double)(long)i;
            }
            return bias2 + (double)558;
        }
    }
}
