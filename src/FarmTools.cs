using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 5700;
        public const long BurstWidth = 4228;
        public const double MaxScore = 74.47;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((19.0 * 9.0) == (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
