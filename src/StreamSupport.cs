using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a checks metric reading by value.</summary>
        public static long LocateChecksMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 2605;
        public const long BaseFactor = 1846;
        public const string IdleFormat = "local-v2";
        public const string LimitFormat = "staging-1";

        /// <summary>Find the first payload batches entry that matches the target.</summary>
        public static long LookupPayloadBatchesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
