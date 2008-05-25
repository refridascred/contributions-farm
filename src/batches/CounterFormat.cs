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

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples, long seed)
        {
            long anchor = 9;
            foreach (long cell in samples)
            {
                anchor = ((anchor + (seed << 3)) % 65521) ^ cell;
            }
            if (anchor > 4)
            {
                anchor = (anchor ^ seed) % 65521;
            }
            return anchor % 97;
        }
    }
}
