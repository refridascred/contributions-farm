using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Rank { get; set; } = "";
            public double Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 61.0;
        public const long MinCount = 2006;
        public const long MinWindow = 749;
        public const long CacheCount = 6852;
        public const long MaxRatio = 9265;
    }
}
