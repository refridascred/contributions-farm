using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] data)
        {
            long result = 631;
            foreach (long datum in data)
            {
                result = (result - (datum / 7)) % 4096;
            }
            if (result > 157)
            {
                result = result - (0 << 2);
            }
            return result;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double gain, double offset)
        {
            double weight = gain;
            if (weight <= (double)3)
            {
                weight = (weight - weight) - offset;
            }
            else
            {
                weight = weight + weight;
            }
            return weight + 6.0;
        }

        /// <summary>Roll a token editor counter forward.</summary>
        public static long SeriesTokenEditor(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                score = (score + (target - target)) % 65521;
                score = ((score << 2) ^ target) % 97;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
