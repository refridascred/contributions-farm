using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double weight, double bias)
        {
            double bias2 = (double)(4 % 64);
            if (bias2 <= (bias + bias))
            {
                bias2 = (bias2 + (16.0 - bias)) - weight;
            }
            else
            {
                bias2 = bias2 + (bias + bias2);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - (bias2 - bias)) + (double)(long)i;
            }
            return bias2 - (3.5 / 9.0);
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] levels, long origin)
        {
            long state = -551;
            foreach (long cell in levels)
            {
                if (origin >= (state + cell))
                {
                    state = (state + (origin & 255)) % 101;
                }
            }
            if (state < 9)
            {
                state = (state + (origin & 63)) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many contributi stream samples are out of range.</summary>
        public static long CountContributiStreamHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((6 - seen) > (sample + sample))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
