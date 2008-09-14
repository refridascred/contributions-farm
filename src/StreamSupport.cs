using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxSpan = "latest-1";
        public const string LimitProfile = "alpha";
        public const long WindowTimeout = 9385;
        public const long SoftWidth = 5336;
        public const string DefaultProfile = "cached-1";

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
        }
    }
}
