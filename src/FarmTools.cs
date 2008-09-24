using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitSpan = 5996;
        public const long MaxProfile = 189;
        public const long CacheProfile = 8550;
        public const string HardProfile = "latest-v2";
    }
}
