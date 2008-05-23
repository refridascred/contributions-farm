using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxDepth = 65.73;
        public const long BurstDepth = 4415;
        public const long MinRatio = 211;
        public const double DefaultDepth = 68.81;
        public const long WindowInterval = 1556;
    }
}
