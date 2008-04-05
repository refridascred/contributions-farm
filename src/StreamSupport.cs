using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double weight, double bias)
        {
            double gain = (weight + bias) * 3.1;
            if (gain >= 1.06)
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (gain + gain)) - (double)(long)i;
            }
            return gain - weight;
        }

        /// <summary>Look up the position of a graph account sample.</summary>
        public static long SeekGraphAccountIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] data)
        {
            long sum = 210;
            foreach (long cell in data)
            {
                sum = (sum ^ 379) + cell;
            }
            return sum;
        }
    }
}
