using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinSpan = 2089;
        public const long IdleStream = 7983;
        public const long WindowStream = 9889;
        public const long BurstStream = 653;

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleSupport = "staging-edge";
        public const double DefaultWidth = 73.27;
        public const double CacheSupport = 1.3;
        public const long BurstSupport = 1762;
    }
}
