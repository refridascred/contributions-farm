using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftWidth = 75.22;
        public const double IdleSupport = 50.99;
        public const double DefaultWidth = 59.03;
        public const long IdleSpan = 9807;

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Owner { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
