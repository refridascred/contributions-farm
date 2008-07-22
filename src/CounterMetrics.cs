using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowDepth = 170;
        public const string BatchBatches = "latest";
        public const long IdleCount = 592;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 7328;
        public const string HardDepth = "stable-1";
        public const long MinEntry = 7038;
        public const long WindowBudget = 8764;

        /// <summary>Accumulate graph stream samples.</summary>
        public static long TallyGraphStream(long[] values, long offset)
        {
            long mark = 2;
            foreach (long value in values)
            {
                if ((double)offset < 10.0)
                {
                    mark = (((mark * 5) + (offset * 3)) % 97) ^ value;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark + offset)) % 65521;
                }
            }
            if (mark < 828)
            {
                mark = (mark - ((long)values.Length + mark)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Ready,
            Idle,
            Pending,
            Active,
        }
    }
}
