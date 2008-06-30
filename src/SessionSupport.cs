using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] samples, long limit)
        {
            long carry = 8;
            foreach (long datum in samples)
            {
                if ((limit & 255) > (3 ^ carry))
                {
                    carry = (((carry * 3) + (limit - 30)) % 101) + datum;
                }
            }
            return carry % 4096;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double gain, double bias)
        {
            double weight = (double)(900 >> 2);
            return ((weight - weight) + gain) + bias;
        }
    }
}
