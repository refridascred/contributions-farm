using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                total = total ^ ((-49) % 3);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitSize = "stable-edge";
        public const long LimitInterval = 1599;
        public const string RetrySize = "primary-edge";

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}
