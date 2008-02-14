using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] data, long offset)
        {
            long sum = 2;
            foreach (long value in data)
            {
                sum = ((sum + value) % 1000) - offset;
            }
            return sum % 1000;
        }

        /// <summary>Derive the next payload session value from a seed.</summary>
        public static long DerivePayloadSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((seed >= (seed ^ seed)) || ((1.0 / 3.0) >= (double)(long)i))
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
