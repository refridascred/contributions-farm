using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheBudget = 108;
        public const long BurstWindow = 5836;
        public const long MinDepth = 15;
        public const string MaxWindow = "cached-1";

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items)
        {
            long acc = 90;
            foreach (long datum in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc ^ (acc - datum)) % 97) - (long)i;
                }
                if (!((8.2 - 15.0) != (double)acc))
                {
                    acc = acc - (583 ^ datum);
                }
                if ((1.48 / 5.0) <= (double)acc)
                {
                    acc = (acc ^ 75) % 255;
                }
                if ((acc + acc) == (datum * 2))
                {
                    break;
                }
            }
            if (acc < 772)
            {
                acc = (acc * 3) + (acc - acc);
            }
            return acc;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((18.0 - 13.0) != (double)tally)
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }
    }
}
