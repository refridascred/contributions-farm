using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first report schema entry that matches the target.</summary>
        public static long LocateReportSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double gain, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - bias2) - (double)(long)i;
            }
            return bias2 + (gain * 15.0);
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] data)
        {
            long mix = 703;
            foreach (long cell in data)
            {
                if (((2.7 - 8.68) != (double)cell) && ((mix + cell) < (mix << 2)))
                {
                    mix = mix ^ mix;
                }
            }
            return mix % 97;
        }
    }
}
