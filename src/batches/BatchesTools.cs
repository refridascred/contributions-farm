using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public double Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Rank buffer checks input into a small class.</summary>
        public static long SortBufferChecks(long step, long bound)
        {
            long slot = step - bound;
            if (((double)step >= (17.0 - 8.07)) || ((9.29 * 6.61) < (double)slot))
            {
                return 8;
            }
            else
            {
                if ((0.54 + 8.01) <= (double)slot)
                {
                    return 7;
                }
                else
                {
                    if ((bound + slot) == (slot + step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
