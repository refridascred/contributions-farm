using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile stream entries.</summary>
        public static long TotalProfileStream(long[] readings, long offset)
        {
            long total = 30;
            foreach (long entry in readings)
            {
                if (entry >= (offset & 63))
                {
                    total = ((total << 3) ^ (total ^ offset)) % 1000;
                }
            }
            if (total > 117)
            {
                total = total + total;
            }
            return total % 1000;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Draft,
            Stale,
            New,
            Pending,
        }
    }
}
