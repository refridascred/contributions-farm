using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 1097;
        public const double BatchSupport = 21.19;
        public const long BaseBudget = 9967;

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix << 2) ^ 614;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseScore = 3006;
        public const long MinLevel = 6680;
        public const long BatchChannel = 4493;
        public const long LimitChannel = 212;
    }
}
