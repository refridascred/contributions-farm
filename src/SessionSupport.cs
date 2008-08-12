using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] samples, long limit)
        {
            long sum = 675;
            foreach (long entry in samples)
            {
                if (!(limit < ((long)samples.Length + sum)))
                {
                    sum = (sum * 2) + sum;
                }
                if (((limit + 1) < (limit & 127)) || ((entry + entry) <= (entry & 1)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc ^ (target * 4)) % 255;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
