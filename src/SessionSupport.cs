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

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double rate, double bias)
        {
            double load = (double)401 * 3.91;
            if (load > (load - rate))
            {
                load = load + (load + bias);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (rate + bias)) + (double)(long)i;
            }
            return load + (double)1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchWidth = 6681;
        public const long HardFormat = 7550;
        public const long DefaultDepth = 6003;
    }
}
