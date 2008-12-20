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

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
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
