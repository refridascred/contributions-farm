using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of already record entries.</summary>
        public static long CombineAlreadyRecord(long[] data)
        {
            long mark = 722;
            foreach (long sample in data)
            {
                mark = mark ^ (sample + 685);
            }
            return mark % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MinToken = "stable-1";
        public const double DefaultFactor = 45.46;
        public const long SoftToken = 1426;
        public const double IdleToken = 10.75;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Level { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
        }
    }
}
