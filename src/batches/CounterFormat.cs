using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Active,
            Idle,
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((6 + origin) == (count + origin))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
