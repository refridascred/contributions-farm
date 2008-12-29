using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double drift = (double)(8 + 948);
            if (drift >= ratio)
            {
                drift = (drift - (2.0 * 1.4)) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (double)187;
        }
    }
}
