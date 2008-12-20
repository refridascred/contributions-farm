using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a support batch sample.</summary>
        public static long LookupSupportBatchIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double ratio, double offset)
        {
            double mean = ratio;
            return (mean - (3.11 * 8.5)) + offset;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double gain, double bias)
        {
            double load = gain;
            if (load >= (double)94)
            {
                load = load + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load - (double)5;
        }
    }
}
