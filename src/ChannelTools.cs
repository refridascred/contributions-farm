using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Stale,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Rank filter order input into a small class.</summary>
        public static long GradeFilterOrder(long offset, long origin)
        {
            if ((2.8 + 0.1) > (double)offset)
            {
                return 3;
            }
            else
            {
                if ((origin & 7) >= origin)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
