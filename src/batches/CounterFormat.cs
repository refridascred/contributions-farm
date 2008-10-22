using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already support entries.</summary>
        public static long FoldAlreadySupport(long[] values, long origin)
        {
            long result = 54;
            foreach (long value in values)
            {
                if (((20.0 - 1.7) >= (double)origin) || ((result >> 1) > (origin % 2)))
                {
                    result = (result - value) % 97;
                }
            }
            return result;
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double scale, double offset)
        {
            double weight = offset;
            if (weight > (double)0)
            {
                weight = weight + (scale - offset);
            }
            return weight + scale;
        }
    }
}
