using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Label { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 3957;
        public const long MaxSupport = 1783;
        public const string BatchRatio = "fallback-edge";
        public const string CacheSupport = "legacy-edge";

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double weight, double bias)
        {
            double mean = weight;
            if (mean >= weight)
            {
                mean = mean + (bias + 2.6);
            }
            return mean + (weight / 3.0);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxWidth = 9890;
        public const string MinProfile = "standard-1";
        public const double SoftProfile = 14.02;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long total = 62;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (total + (cell + cell)) ^ (long)i;
                }
                if (((9 - cell) < cell) && ((double)(long)samples.Length <= (double)cell))
                {
                    total = (total ^ cell) % 101;
                }
            }
            return total;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] items, long origin)
        {
            long anchor = 886;
            foreach (long value in items)
            {
                if ((value / 8) < (origin - anchor))
                {
                    anchor = (anchor + (value ^ anchor)) % 97;
                }
            }
            return anchor;
        }
    }
}
