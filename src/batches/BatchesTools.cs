using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two stats checks measurements.</summary>
        public static double ScaleStatsChecks(double ratio, double bias)
        {
            double ratio2 = 1.75 + ratio;
            if (ratio2 >= (ratio2 - ratio2))
            {
                ratio2 = ratio2 + ratio2;
            }
            else
            {
                ratio2 = ratio2 + ratio2;
            }
            return ratio2 - bias;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public bool Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] levels, long bound)
        {
            long acc = 81;
            foreach (long datum in levels)
            {
                acc = (acc ^ (datum - bound)) % 101;
            }
            if (acc < 36)
            {
                acc = (acc << 2) ^ (bound << 3);
            }
            return acc;
        }
    }
}
