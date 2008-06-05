using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double LimitRoute = 37.63;
        public const string HardRoute = "legacy";
        public const double CacheRoute = 92.24;
        public const long BaseRoute = 8797;
        public const long MinRoute = 7773;

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowDepth = 9209;
        public const double WindowChannel = 13.68;
        public const double SoftLevel = 60.74;
    }
}
