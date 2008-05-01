using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseLevel = 12.31;
        public const long LimitSpan = 3161;
        public const long LimitDepth = 4476;
        public const double SoftInterval = 51.48;

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftTimeout = "primary";
        public const long StepCount = 67;
        public const string WindowInterval = "cached-1";
    }
}
