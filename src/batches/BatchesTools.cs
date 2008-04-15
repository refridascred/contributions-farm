using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long floor, long floor2)
        {
            long slot = floor ^ floor2;
            if (!((floor - 391) >= 6))
            {
                return 7;
            }
            else
            {
                if ((slot < (floor ^ slot)) && ((double)floor > (double)floor2))
                {
                    return 3;
                }
                else
                {
                    if ((floor >> 1) != (floor2 + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
