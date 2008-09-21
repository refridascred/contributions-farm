using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double bias, double floor)
        {
            double scale = (bias / 6.0) / 9.0;
            return (scale - 16.0) + floor;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum & 127) >= (datum + count))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
