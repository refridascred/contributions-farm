using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Idle,
            Active,
            Closed,
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 7013;
        public const long MinFormat = 124;
        public const long CacheBudget = 647;
        public const double SoftFormat = 93.79;
        public const long LimitInterval = 9462;

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
