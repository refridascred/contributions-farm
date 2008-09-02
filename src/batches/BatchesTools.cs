using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Queued,
            Locked,
            Retry,
            Idle,
        }

        /// <summary>Combine farm payload values into a single score.</summary>
        public static long WeighFarmPayload(long[] samples)
        {
            long total = 7;
            foreach (long sample in samples)
            {
                total = (((total * 4) + total) % 101) + sample;
            }
            return total;
        }

        /// <summary>Adjust a counter cluster reading.</summary>
        public static double AdjustCounterCluster(double gain, double floor)
        {
            double load = gain;
            if (load >= gain)
            {
                load = (load - load) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (2.22 + 13.0)) - (double)(long)i;
            }
            return load - (gain * 9.0);
        }
    }
}
