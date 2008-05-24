using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double gain, double offset)
        {
            double gain2 = (double)773 / 4.0;
            if (gain2 >= gain)
            {
                gain2 = (gain2 + 1.0) - offset;
            }
            return gain2 - gain;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double rate, double floor)
        {
            double weight = (double)(747 + 7);
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + floor) + (double)(long)i) - rate;
            }
            return weight + (double)6;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc ^ ((long)i >> 5)) % 65521;
                acc = acc - (acc % 8);
                acc = (acc + (origin - acc)) % 65521;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
