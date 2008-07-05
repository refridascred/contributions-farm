using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Limit { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long offset, long target)
        {
            long bound = offset - target;
            if ((offset - target) < (target + bound))
            {
                return 6;
            }
            else
            {
                if ((offset < (offset + 96)) && ((72 - 7) < bound))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultTimeout = 77.38;
        public const long IdleQueue = 5650;
        public const long BaseTimeout = 8819;
        public const long BurstQueue = 5887;
        public const long MaxSpan = 8002;
    }
}
