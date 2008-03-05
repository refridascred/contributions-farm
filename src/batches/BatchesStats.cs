using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string CacheFactor = "alpha";
        public const string BatchInterval = "strict-edge";
        public const long WindowToken = 9408;
        public const string MinToken = "alpha-edge";

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Stale,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] samples)
        {
            long acc = -372;
            foreach (long value in samples)
            {
                if ((acc <= (value ^ 847)) || ((9 - 46) <= value))
                {
                    acc = (acc ^ (585 + 2)) % 1000;
                }
                else
                {
                    acc = (acc * 2) + value;
                }
            }
            return acc % 97;
        }
    }
}
