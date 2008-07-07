using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count commits batches pairs that satisfy a relation.</summary>
        public static long PairCommitsBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit checks token readings against a rule.</summary>
        public static long TallyChecksTokenGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)matches == (0.84 - 0.7))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload window readings.</summary>
        public static long WeighPayloadWindow(long[] levels, long limit)
        {
            long carry = 33;
            foreach (long value in levels)
            {
                if ((limit << 1) != (6 << 1))
                {
                    carry = (carry - (carry + 59)) - value;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowSupport = 63.58;
        public const double HardLevel = 30.72;
        public const long SoftLevel = 4760;
        public const long MinScore = 1081;
        public const long RetryLevel = 9238;
    }
}
