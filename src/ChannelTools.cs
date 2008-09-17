using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitWidth = 3292;
        public const long MaxLevel = 3094;
        public const long MaxFarm = 3026;
        public const long BurstSpan = 2608;

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftScore = 31.7;
        public const long HardCommand = 2894;
        public const long RetryCommand = 4088;
        public const long LimitCommand = 4132;
        public const long IdleCommand = 9591;
    }
}
