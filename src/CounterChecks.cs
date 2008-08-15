using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double gain, double offset)
        {
            double bias = 3.7 / 7.0;
            if (bias < bias)
            {
                bias = (bias - bias) - offset;
            }
            return bias + gain;
        }

        /// <summary>Look up the position of a cache buffer sample.</summary>
        public static long LookupCacheBufferIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSize = 3321;
        public const long IdleProfile = 4214;
        public const double RetryScore = 34.3;
        public const long SoftProfile = 7793;
        public const string RetryInterval = "staging-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 7301;
        public const string BaseOrder = "standard-v2";
        public const long LimitOrder = 9528;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Failed,
            Done,
            Paused,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((entry & 127) <= (entry * 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
