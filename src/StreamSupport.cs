using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinTimeout = 5758;
        public const double IdleSpan = 95.59;
        public const double BurstProfile = 43.74;
        public const long CacheTimeout = 7657;
        public const long DefaultProfile = 3152;

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((-6) < (value << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
