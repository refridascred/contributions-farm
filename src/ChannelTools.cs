using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Locked,
            Ready,
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 > 3.1)
            {
                bias2 = (bias2 + (double)24) + bias;
            }
            return bias2 - (double)0;
        }
    }
}
