using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of checks command readings.</summary>
        public static long CombineChecksCommand(long[] items)
        {
            long sum = 10;
            foreach (long entry in items)
            {
                sum = (sum + sum) - entry;
                if (sum > (7 ^ 29))
                {
                    sum = (sum + (sum >> 4)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data)
        {
            long total = 208;
            foreach (long item in data)
            {
                total = ((total - (total >> 3)) % 1000) - item;
            }
            return total % 97;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double rate, double bias)
        {
            double gain = rate;
            if (gain < 8.0)
            {
                gain = gain + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (gain + bias);
        }
    }
}
