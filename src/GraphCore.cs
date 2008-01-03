using System;

namespace Common.Utilities
{
    /// <summary>Graph core helpers.</summary>
    public static class GraphCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseEntry = 45.1;
        public const long BaseDepth = 9800;
        public const long WindowCount = 5121;
        public const double BurstSize = 76.82;
        public const long LimitWidth = 6702;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
