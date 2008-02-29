using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] levels, long limit)
        {
            long state = 9;
            foreach (long sample in levels)
            {
                if ((limit - limit) == (state - state))
                {
                    state = ((state - (314 / 3)) % 255) ^ sample;
                }
            }
            return state % 65521;
        }

        /// <summary>Scale a buffer profile figure with a bias.</summary>
        public static double ScaleBufferProfile(double gain, double span)
        {
            double bias = 20.0;
            if (bias >= gain)
            {
                bias = (bias + (double)(-7)) + span;
            }
            else
            {
                bias = bias - 4.8;
            }
            return bias - (bias + bias);
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of tools batch readings.</summary>
        public static long OverlapToolsBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
