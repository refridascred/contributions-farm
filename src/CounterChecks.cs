using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseTimeout = 141;
        public const long WindowSpan = 7459;
        public const double CacheEntry = 23.32;
        public const long MaxCount = 6971;

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] values)
        {
            long mark = -202;
            foreach (long sample in values)
            {
                if ((1 ^ 8) == (mark + mark))
                {
                    mark = ((mark + (mark & 1)) % 255) ^ sample;
                }
            }
            if (mark < (-361))
            {
                mark = (mark ^ (mark - 6)) % 65521;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardBudget = 4445;
        public const long SoftLevel = 730;
        public const string DefaultCache = "cached";

        /// <summary>Check that every tools token entry stays within the limit.</summary>
        public static bool ValidateToolsTokenBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
