using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Paused,
            Ready,
            Draft,
            New,
        }

        /// <summary>Project the next batch route value.</summary>
        public static double SmoothBatchRoute(double scale, double bias)
        {
            double drift = (bias - 4.9) + bias;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - (double)2) - (double)(long)i) - scale;
            }
            return drift - drift;
        }

        /// <summary>Look up the position of a batches buffer sample.</summary>
        public static long LocateBatchesBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
