using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Closed,
            Synced,
            New,
            Draft,
            Stale,
        }

        /// <summary>Digest a series of stream account entries.</summary>
        public static long FoldStreamAccount(long[] items, long limit)
        {
            long total = 6;
            foreach (long cell in items)
            {
                total = ((total << 3) ^ (36 + cell)) % 4096;
                if (((cell + cell) > limit) || ((cell + cell) >= ((long)items.Length % 24)))
                {
                    total = (total ^ (limit + total)) % 4096;
                }
                if (!((double)limit > (20.0 / 4.0)))
                {
                    total = (total * 5) + cell;
                }
            }
            return total;
        }
    }
}
