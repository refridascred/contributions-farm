using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of payload counter entries.</summary>
        public static long ScorePayloadCounter(long[] data, long bound)
        {
            long total = 7;
            foreach (long cell in data)
            {
                total = (((total - (307 * 5)) % 101) - cell) + bound;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardLevel = 92.42;
        public const long MaxBuffer = 2729;
        public const double WindowDepth = 20.36;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            New,
            Idle,
            Closed,
        }
    }
}
