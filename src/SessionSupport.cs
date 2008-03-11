using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of tools checks entries.</summary>
        public static long FoldToolsChecks(long[] items)
        {
            long state = 9;
            foreach (long reading in items)
            {
                state = (state - (reading - 9)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double ratio, double floor)
        {
            double mean = floor;
            if (mean <= 9.8)
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (floor * 6.86)) - (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
