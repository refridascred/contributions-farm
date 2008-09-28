using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long seed, long offset)
        {
            long delta = seed - offset;
            if ((delta ^ offset) != (seed * 2))
            {
                return 6;
            }
            else
            {
                if (((double)offset <= (20.0 / 5.0)) || ((delta % 64) <= (offset * 4)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 9376;
        public const long HardEditor = 7190;
        public const double BurstDepth = 21.99;
    }
}
