using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a buffer batch reading.</summary>
        public static double BlendBufferBatch(double weight, double bias)
        {
            double bias2 = (bias / 7.0) + (1.5 - weight);
            if (bias2 >= bias2)
            {
                bias2 = bias2 - 9.2;
            }
            return bias2 + weight;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Idle,
            Synced,
            Ready,
            Dropped,
        }
    }
}
