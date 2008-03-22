using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] samples, long target)
        {
            long result = 86;
            foreach (long datum in samples)
            {
                result = ((result - datum) % 4096) - target;
            }
            return result % 1000;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double bias, double bias2)
        {
            double load = (double)21 * 7.0;
            if (load >= (bias - bias))
            {
                load = (load - (load + bias)) - bias2;
            }
            return load + load;
        }
    }
}
