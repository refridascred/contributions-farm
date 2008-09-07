using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a record filter value against two limits.</summary>
        public static long GradeRecordFilter(long origin, long bound)
        {
            long step = origin - bound;
            if (((origin << 3) != (bound - bound)) || ((origin - 71) <= (origin + (-34))))
            {
                return 4;
            }
            else
            {
                if (step >= origin)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                if (!((seed + carry) != (seed & 31)))
                {
                    carry = ((carry << 3) ^ ((long)i ^ seed)) % 97;
                    continue;
                }
                if ((seed % 24) > (long)i)
                {
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
