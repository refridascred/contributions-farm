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

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Stamp { get; set; }
            public bool Region { get; set; }
            public bool Count { get; set; }
        }
    }
}
