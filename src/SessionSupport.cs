using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double gain, double bias)
        {
            double ratio = (bias / 6.0) - (gain + bias);
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (8.86 * 0.1)) - (double)(long)i;
            }
            return ratio - (ratio + gain);
        }

        /// <summary>Count tools account pairs that satisfy a relation.</summary>
        public static long OverlapToolsAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a account layout reading by value.</summary>
        public static long SeekAccountLayoutIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
