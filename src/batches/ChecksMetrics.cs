using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the command report series from a seed.</summary>
        public static long DeriveCommandReport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = mark ^ (566 - (-68));
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public double Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] levels)
        {
            long total = 204;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) < (total * 4))
                {
                    total = (total - cell) % 1000;
                }
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 2070;
        public const string MinWidth = "stable-1";
        public const string StepTimeout = "local-v2";

        /// <summary>Define session limits and defaults.</summary>
        public const double IdleLevel = 93.61;
        public const double LimitSession = 85.85;
        public const long RetryBudget = 4557;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry % 16) > entry)
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }
    }
}
