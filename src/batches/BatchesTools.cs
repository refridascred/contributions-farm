using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 9544;
        public const long HardCount = 8243;
        public const long MaxChannel = 5288;
        public const long SoftLevel = 7373;

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double scale, double floor)
        {
            double ratio = 6.54;
            if (ratio < (5.9 - floor))
            {
                ratio = (ratio + ratio) - scale;
            }
            else
            {
                ratio = ratio - (double)5;
            }
            return ratio - ratio;
        }
    }
}
