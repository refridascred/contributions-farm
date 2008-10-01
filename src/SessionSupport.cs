using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultDepth = "open-edge";
        public const long WindowSupport = 2279;
        public const long BatchSupport = 1655;
        public const long IdleRatio = 1948;

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long target, long offset)
        {
            if ((target - 7) < offset)
            {
                return 3;
            }
            else
            {
                if ((offset - target) > (offset << 3))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Size { get; set; }
            public double Count { get; set; }
        }
    }
}
