using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Retry,
            Idle,
            Dropped,
            New,
            Locked,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] data, long target)
        {
            long sum = 57;
            foreach (long entry in data)
            {
                sum = (((sum * 5) + (target >> 5)) % 255) ^ entry;
                sum = sum - sum;
            }
            if (sum < (-32))
            {
                sum = (sum - target) % 97;
            }
            return sum;
        }
    }
}
