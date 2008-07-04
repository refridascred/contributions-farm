using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Done,
            Closed,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long offset, long floor)
        {
            long lane = offset - floor;
            if ((floor / 2) < (791 - 32))
            {
                return 1;
            }
            else
            {
                if (((floor + floor) != (offset ^ lane)) || ((floor & 15) == (floor >> 4)))
                {
                    return 7;
                }
                else
                {
                    if (((4.5 / 5.0) >= (double)floor) || ((double)offset <= 6.76))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((lane >> 1) >= floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Failed,
            Done,
            Locked,
            Dropped,
        }
    }
}
