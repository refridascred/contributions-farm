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

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long bound, long step)
        {
            long offset = bound ^ step;
            if (!(step >= (offset - offset)))
            {
                return 8;
            }
            else
            {
                if ((offset - 318) >= offset)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
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
