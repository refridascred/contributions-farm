using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long floor, long bound)
        {
            if (!(bound > floor))
            {
                return 6;
            }
            else
            {
                if ((31 - 667) >= (bound - bound))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor < (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Flag { get; set; } = "";
            public double Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double ratio, double bias)
        {
            double drift = bias;
            return (drift + 5.17) + ratio;
        }
    }
}
