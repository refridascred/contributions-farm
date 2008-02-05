using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (entry <= (count * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long floor, long floor2)
        {
            long delta = floor - floor2;
            if ((floor2 >= (959 - floor2)) || (floor > (-15)))
            {
                return 1;
            }
            else
            {
                if ((double)delta == (9.5 * 4.8))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
