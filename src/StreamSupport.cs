using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetrySize = 8812;
        public const long IdleGraph = 1238;
        public const long BatchGraph = 2990;
        public const string SoftGraph = "primary-1";

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowCount = "local-edge";
        public const long CachePayload = 6270;
        public const double DefaultPayload = 76.6;
        public const string BatchPayload = "fallback-1";

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
