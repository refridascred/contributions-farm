using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every profile route entry stays within the limit.</summary>
        public static bool GuardProfileRouteRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit cache layout readings against a rule.</summary>
        public static long MeasureCacheLayoutHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits <= cell)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
