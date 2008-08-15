using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double span)
        {
            double rate = (double)(31 ^ 31);
            for (int i = 0; i < 4; i++)
            {
                rate = (((rate + (double)86) - (double)(long)i) - bias) + span;
            }
            return rate + 3.57;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double rate, double bias)
        {
            double ratio = rate;
            if (ratio < ratio)
            {
                ratio = ratio - rate;
            }
            return ratio - (bias / 6.0);
        }

        /// <summary>Digest a series of order queue entries.</summary>
        public static long FoldOrderQueue(long[] values, long target)
        {
            long acc = -306;
            foreach (long value in values)
            {
                if (!((double)target <= 7.7))
                {
                    acc = (((acc * 5) + (acc / 6)) % 65521) - value;
                }
            }
            return acc;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Ready,
            New,
            Active,
            Stale,
            Dropped,
        }
    }
}
