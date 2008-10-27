using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Locked,
            Dropped,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] series)
        {
            long total = 429;
            foreach (long value in series)
            {
                if (((double)total <= 2.0) || ((value / 9) >= (value + total)))
                {
                    total = total - (85 >> 5);
                }
                else
                {
                    total = total + (total * 5);
                }
            }
            return total;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
        }
    }
}
