using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a editor window counter forward.</summary>
        public static long IterateEditorWindow(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultScore = 4726;
        public const long BaseWindow = 7894;
        public const double RetryWindow = 53.32;

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchTimeout = 718;
        public const long DefaultWindow = 2515;
        public const long WindowCount = 8654;
        public const long MinDepth = 7802;
    }
}
