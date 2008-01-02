using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= (weight + weight2))
            {
                weight2 = weight2 + (weight / 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 - (offset / 9.0)) + (double)(long)i;
            }
            return weight2 + (double)5;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchWidth = 6681;
        public const long HardFormat = 7550;
        public const long DefaultDepth = 6003;
    }
}
