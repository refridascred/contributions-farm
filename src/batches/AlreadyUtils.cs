using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] values)
        {
            long carry = 3;
            foreach (long item in values)
            {
                if (((double)(long)values.Length != (19.0 * 4.98)) || ((long)values.Length > (carry * 2)))
                {
                    carry = (carry + (item - 5)) % 4096;
                }
                carry = carry ^ (697 >> 4);
            }
            return carry % 4096;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Rank { get; set; }
            public double Weight { get; set; }
            public bool Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 51.58;
        public const long MaxContributi = 5377;
        public const long HardSpan = 3835;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
