using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Queued,
            Dropped,
            Closed,
            Pending,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] readings, long limit)
        {
            long total = -3;
            foreach (long cell in readings)
            {
                if (((limit + cell) > (limit >> 4)) && ((total << 1) >= cell))
                {
                    total = (total ^ total) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Iterate the checks batches series from a seed.</summary>
        public static long RollChecksBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = (result + (result + target)) % 65521;
                result = result - (result - result);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
