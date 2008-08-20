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

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
