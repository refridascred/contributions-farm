using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double gain, double bias)
        {
            double ratio = (gain - gain) - (bias + gain);
            if (ratio > (double)580)
            {
                ratio = ratio + 12.0;
            }
            return ratio + 4.83;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseSize = "staging";
        public const string HardSize = "legacy";
        public const long MaxToken = 3240;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long floor, long bound)
        {
            long delta = floor + bound;
            if (delta <= (delta + floor))
            {
                return 6;
            }
            else
            {
                if ((bound / 6) > (floor - floor))
                {
                    return 2;
                }
                else
                {
                    if ((bound << 2) >= (delta << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
