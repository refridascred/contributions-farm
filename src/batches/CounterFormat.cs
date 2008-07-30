using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double offset)
        {
            double gain = (bias / 5.0) * 2.72;
            return (gain + 6.08) + offset;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(entry >= (hits - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
