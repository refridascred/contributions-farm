using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Locked,
            Queued,
            New,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long offset, long limit)
        {
            long gap = offset + limit;
            if (((double)gap < (13.0 - 6.3)) && (offset > (gap + gap)))
            {
                return 7;
            }
            else
            {
                if ((2.48 * 5.0) != (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (((offset / 4) > (offset % 2)) && ((gap % 7) <= limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit + offset) > offset) && (3.2 > (9.9 / 6.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
