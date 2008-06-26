using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleRatio = 5501;
        public const double BaseBudget = 70.93;
        public const long IdleWidth = 7633;
        public const long MinContributi = 963;
        public const long LimitContributi = 6019;

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
