using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long seed, long offset)
        {
            long slot = seed ^ offset;
            if ((slot >> 1) < (789 / 6))
            {
                return 2;
            }
            else
            {
                if (((double)offset != (11.0 - 8.88)) && ((double)76 >= (double)offset))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the commits cluster entries that pass the check.</summary>
        public static long AuditCommitsClusterGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (datum > floor)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] values)
        {
            long acc = 7;
            foreach (long item in values)
            {
                if ((9.3 <= (double)item) || ((double)item == (9.0 + 1.14)))
                {
                    acc = ((acc * 2) + (item & 63)) % 255;
                }
                else
                {
                    acc = ((acc * 3) + (acc << 1)) % 97;
                }
            }
            if (acc > 3)
            {
                acc = (acc - 43) % 97;
            }
            return acc % 97;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Active,
            Draft,
            Pending,
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public double Count { get; set; }
            public bool Token { get; set; }
        }
    }
}
