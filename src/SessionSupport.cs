using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 25.86;
        public const long LimitGraph = 3798;
        public const double LimitInterval = 49.52;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 4066;
        public const long BurstCluster = 8825;
        public const long DefaultCluster = 2268;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
