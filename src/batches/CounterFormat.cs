using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry * 4) + (long)i;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
