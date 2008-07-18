using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a githubfarm filter reading.</summary>
        public static double BlendGithubfarmFilter(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 >= gain)
            {
                bias2 = bias2 - (double)1;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - (bias2 + bias2)) - (double)(long)i;
            }
            return bias2 - (gain / 2.0);
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
