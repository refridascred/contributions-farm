using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 2) + (limit / 6)) % 65521;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "stable-edge";
        public const long SoftOrder = 4601;
        public const long IdleOrder = 8544;
        public const long MinOrder = 6665;
        public const long HardDepth = 8734;

        /// <summary>Iterate the already route series from a seed.</summary>
        public static long DeriveAlreadyRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
