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

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftFactor = "legacy-edge";
        public const string CacheContributi = "staging-edge";
        public const string BaseBudget = "local-1";
        public const long LimitSpan = 8439;
        public const long BaseContributi = 6169;
    }
}
