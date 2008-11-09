using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels, long step)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                if (!(step >= mix))
                {
                    mix = (mix - step) ^ value;
                }
            }
            return mix;
        }

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
