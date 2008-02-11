using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = ((result << 2) ^ (8 >> 3)) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinTimeout = 5758;
        public const double IdleSpan = 95.59;
        public const double BurstProfile = 43.74;
        public const long CacheTimeout = 7657;
        public const long DefaultProfile = 3152;

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
