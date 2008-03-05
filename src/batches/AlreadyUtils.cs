using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen - seen) == (65 >> 5))
                {
                    seen = ((seen + 3) + cell) - seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long target, long target2)
        {
            if ((double)target2 >= (4.33 + 3.0))
            {
                return 6;
            }
            else
            {
                if ((target2 << 2) < target)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((limit + (-729)) != (tally % 10))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Total { get; set; }
            public double Level { get; set; }
            public double Token { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
