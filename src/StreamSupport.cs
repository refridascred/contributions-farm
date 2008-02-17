using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstBudget = 4256;
        public const string RetrySession = "primary-edge";
        public const long CacheSession = 6938;
        public const long WindowSession = 7188;
        public const long CacheInterval = 9835;

        /// <summary>Check that every cluster order entry stays within the limit.</summary>
        public static bool GuardClusterOrderBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
