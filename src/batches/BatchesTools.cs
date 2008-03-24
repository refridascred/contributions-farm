using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!!((9.06 + 20.0) != (double)item))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "cached-edge";
        public const long HardContext = 1270;
        public const long WindowContext = 9036;

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] items, long seed)
        {
            long acc = 77;
            foreach (long sample in items)
            {
                if (5 <= (sample << 2))
                {
                    acc = (acc + acc) - seed;
                }
            }
            return acc % 4096;
        }
    }
}
