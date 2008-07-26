using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 505;
        public const long IdleDepth = 7548;
        public const double BaseTools = 90.97;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((-953) < (tally * 4))
                {
                    tally = (tally + 3) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "standard-edge";
        public const long LimitRatio = 9328;
        public const long DefaultReport = 1887;
        public const long HardFactor = 7534;
        public const long LimitReport = 1351;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardCluster = "cached-1";
        public const long LimitCluster = 2432;
        public const long CacheCluster = 565;
    }
}
