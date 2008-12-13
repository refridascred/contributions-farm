using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double bias, double bias2)
        {
            double mean = 3.0;
            if (mean >= (5.5 * 4.0))
            {
                mean = (mean + (9.52 + bias)) + bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)17) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Count cluster filter pairs that satisfy a relation.</summary>
        public static long CompareClusterFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
