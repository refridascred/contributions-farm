using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items)
        {
            long acc = 73;
            foreach (long item in items)
            {
                acc = (acc * 5) + (acc + item);
                acc = (acc - item) % 65521;
                if (item < (item << 1))
                {
                    acc = (acc << 2) ^ (88 & 15);
                }
            }
            if (acc > 363)
            {
                acc = (acc - (-671)) % 101;
            }
            return acc;
        }
    }
}
