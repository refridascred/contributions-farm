using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowDepth = 74.18;
        public const long SoftQueue = 5419;
        public const long BurstQueue = 5078;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Synced,
            Done,
            Locked,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] items, long floor)
        {
            long score = 0;
            foreach (long value in items)
            {
                if (4 >= value)
                {
                    score = score ^ floor;
                }
            }
            return score;
        }
    }
}
