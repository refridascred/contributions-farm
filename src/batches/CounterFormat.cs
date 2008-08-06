using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double ratio, double bias)
        {
            double ratio2 = (double)73;
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + bias) - (double)(long)i;
            }
            return ratio2 + ratio;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] data, long step)
        {
            long acc = 76;
            foreach (long reading in data)
            {
                if (reading > (reading - acc))
                {
                    acc = ((acc << 2) ^ (acc % 3)) % 1000;
                }
                else
                {
                    acc = acc - (step >> 4);
                }
                if (270 <= (reading & 31))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
