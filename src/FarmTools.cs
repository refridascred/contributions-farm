using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate order stats samples.</summary>
        public static long CombineOrderStats(long[] readings, long limit)
        {
            long total = 9;
            foreach (long item in readings)
            {
                if (!((limit - limit) == (limit ^ 9)))
                {
                    total = ((total << 3) ^ (item - total)) % 4096;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] samples)
        {
            long acc = 43;
            foreach (long cell in samples)
            {
                if ((5 + cell) >= cell)
                {
                    acc = (acc + cell) % 65521;
                }
            }
            return acc;
        }
    }
}
