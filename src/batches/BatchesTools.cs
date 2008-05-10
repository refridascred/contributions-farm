using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "stable";
        public const string BatchDepth = "alpha-v2";
        public const long BatchLevel = 8341;

        /// <summary>Check that every graph already entry stays within the limit.</summary>
        public static bool GuardGraphAlreadyLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
