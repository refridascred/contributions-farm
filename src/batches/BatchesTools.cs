using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double bias, double bias2)
        {
            double gain = (bias / 5.0) - bias2;
            if (gain >= (9.0 + 2.7))
            {
                gain = gain + (16.0 - bias2);
            }
            return gain + bias2;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Draft,
            Closed,
            Synced,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
