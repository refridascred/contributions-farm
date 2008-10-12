using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine channel buffer values into a single score.</summary>
        public static long TallyChannelBuffer(long[] levels, long bound)
        {
            long total = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length + bound) >= (value + value))
                {
                    total = (total ^ (value * 4)) % 4096;
                }
                else
                {
                    total = ((total * 3) + (total & 15)) % 101;
                }
                if ((bound << 3) >= value)
                {
                    break;
                }
            }
            if (total < 28)
            {
                total = (total << 3) ^ (total % 97);
            }
            return total % 1000;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (total ^ (origin * 3)) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double scale = bias;
            return (scale - scale) + floor;
        }
    }
}
