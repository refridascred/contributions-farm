using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit command channel readings against a rule.</summary>
        public static long AuditCommandChannelOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((cell << 3) > floor) && (((cell ^ 40) >= (seen ^ floor)) && (((-43) - floor) > seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
