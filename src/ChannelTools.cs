using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next token record value from a seed.</summary>
        public static long StepTokenRecord(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleDepth = "stable-1";
        public const long LimitFilter = 9852;
        public const long MaxWidth = 9488;

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseFactor = 34.27;
        public const string BaseAccount = "local-1";
        public const string MaxAccount = "local-v2";
    }
}
