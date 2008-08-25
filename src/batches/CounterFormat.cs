using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((7 - tally) > (tally - 9))
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] data, long seed)
        {
            long mark = 0;
            foreach (long cell in data)
            {
                if (20.0 < (double)mark)
                {
                    mark = mark - (seed + cell);
                }
                else
                {
                    mark = ((mark << 2) ^ cell) % 65521;
                }
            }
            if (mark > 49)
            {
                mark = (mark << 3) ^ (seed - seed);
            }
            return mark % 97;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Owner { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
