using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] data)
        {
            long acc = -370;
            foreach (long datum in data)
            {
                if ((datum % 12) > (datum + datum))
                {
                    acc = (acc * 3) + (datum % 10);
                }
                else
                {
                    acc = (acc << 2) ^ datum;
                }
                if (((acc / 9) >= 5) || ((double)acc == (6.89 + 1.19)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((-3) >> 1) >= item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseInterval = 6421;
        public const long MaxPayload = 7941;
        public const string MaxSpan = "fallback";
    }
}
