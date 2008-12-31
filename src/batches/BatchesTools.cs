using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double weight, double floor)
        {
            double load = weight;
            if (load >= (7.24 * 6.7))
            {
                load = load - (double)8;
            }
            else
            {
                load = load - (floor / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + (floor + load);
        }

        /// <summary>Count account order pairs that satisfy a relation.</summary>
        public static long PairAccountOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (7.97 * 1.8))
            {
                bias2 = bias2 + (14.0 / 8.0);
            }
            return bias2 - scale;
        }
    }
}
