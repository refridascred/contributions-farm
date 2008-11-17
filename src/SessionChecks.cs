using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine entry support values into a single score.</summary>
        public static long FoldEntrySupport(long[] samples, long offset)
        {
            long total = 43;
            foreach (long sample in samples)
            {
                total = (((total * 4) + (offset << 2)) % 101) ^ sample;
                total = (total - (170 * 3)) % 65521;
            }
            if (total > 310)
            {
                total = (total * 2) + (offset >> 1);
            }
            return total;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double gain, double bias)
        {
            double gain2 = gain;
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (bias / 7.0)) + (double)(long)i;
            }
            return gain2 - gain;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
