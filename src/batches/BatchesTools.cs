using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheScore = 965;
        public const long IdleTimeout = 4019;
        public const string IdleProfile = "strict";
        public const long LimitProfile = 8228;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 870;
        public const double BaseToken = 16.11;
        public const double CacheToken = 86.79;
        public const double DefaultToken = 3.34;
        public const double WindowSpan = 46.96;
    }
}
