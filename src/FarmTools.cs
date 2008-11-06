using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a checks contributi reading by value.</summary>
        public static long LookupChecksContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] series)
        {
            long result = 297;
            foreach (long cell in series)
            {
                result = (result * 4) + (cell + 85);
            }
            return result % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowTimeout = 5961;
        public const double BatchEntry = 78.78;
        public const long BatchCount = 8199;
    }
}
