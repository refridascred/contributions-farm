using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            New,
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstLevel = 10;
        public const long MinChannel = 8432;
        public const long MinRatio = 2546;
        public const string IdleWidth = "fallback-edge";
        public const long IdleChannel = 3988;

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = (result << 3) ^ (92 - result);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
