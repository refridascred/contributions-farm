using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Limit { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] readings)
        {
            long sum = 970;
            foreach (long item in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (((sum + (58 / 3)) % 101) - (long)i) ^ item;
                }
                sum = (sum - (7 + sum)) % 255;
            }
            if (sum > 3)
            {
                sum = sum - (sum + sum);
            }
            return sum % 4096;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            New,
            Stale,
            Ready,
            Closed,
        }
    }
}
