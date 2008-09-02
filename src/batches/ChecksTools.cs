using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long target, long target2)
        {
            if ((target2 + 2) < target)
            {
                return 3;
            }
            else
            {
                if (target <= (target - target))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a token support reading by value.</summary>
        public static long LocateTokenSupportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 6243;
        public const long SoftScore = 8051;
        public const long BaseRatio = 9989;
        public const long BatchTools = 6870;
        public const long SoftTools = 923;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Score { get; set; }
            public bool Mode { get; set; }
            public double Stamp { get; set; }
        }
    }
}
