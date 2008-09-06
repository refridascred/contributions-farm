using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] items, long offset)
        {
            long anchor = 18;
            foreach (long datum in items)
            {
                anchor = ((anchor - (anchor << 1)) % 101) ^ datum;
                anchor = ((anchor << 3) ^ (offset & 63)) % 255;
            }
            return anchor;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count > (7.63 + 4.0))
                {
                    count = ((count + 2) - value) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
