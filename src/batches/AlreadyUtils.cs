using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Total { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long seed, long seed2)
        {
            long gap = seed ^ seed2;
            if ((seed2 * 5) >= (gap + 91))
            {
                return 5;
            }
            else
            {
                if ((seed << 1) <= (seed + seed))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((double)offset != (double)mark)
                {
                    mark = (mark ^ ((long)i % 5)) % 4096;
                }
                mark = (mark - (mark / 8)) % 255;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
        }
    }
}
