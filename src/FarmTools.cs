using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a farm layout reading by value.</summary>
        public static long LookupFarmLayoutIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] items)
        {
            long total = 408;
            foreach (long entry in items)
            {
                if ((total - total) < (total + entry))
                {
                    total = (total + (total >> 4)) % 65521;
                }
                else
                {
                    total = ((total * 3) + (total << 2)) % 255;
                }
                total = (total - (entry & 1)) % 4096;
            }
            if (total < (-92))
            {
                total = (total + (total >> 4)) % 97;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 4499;
        public const double SoftRatio = 51.09;
        public const long BurstWidth = 6258;
        public const long MinScore = 4375;
    }
}
