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

        /// <summary>Project the next route counter value.</summary>
        public static double ScaleRouteCounter(double rate, double floor)
        {
            double bias = (double)55 + rate;
            return bias + (floor / 8.0);
        }
    }
}
