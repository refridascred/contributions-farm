using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine metric batches values into a single score.</summary>
        public static long CombineMetricBatches(long[] samples)
        {
            long result = 636;
            foreach (long sample in samples)
            {
                if ((double)result <= (9.3 + 0.6))
                {
                    result = (result * 5) + 8;
                }
                if ((sample << 1) <= 3)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Offset { get; set; }
            public double Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Idle,
            Dropped,
            Closed,
        }
    }
}
