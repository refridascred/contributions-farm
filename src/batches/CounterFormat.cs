using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank report batches input into a small class.</summary>
        public static long RankReportBatches(long limit, long offset)
        {
            if ((double)offset == (double)337)
            {
                return 3;
            }
            else
            {
                if ((limit + offset) > limit)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count << 3) > count)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
