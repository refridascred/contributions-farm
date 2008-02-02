using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long offset, long floor)
        {
            long lane = offset ^ floor;
            if (((double)offset != (double)lane) && ((lane - floor) < (lane >> 4)))
            {
                return 6;
            }
            else
            {
                if ((double)floor == (9.96 * 0.07))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
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
