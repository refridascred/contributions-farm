using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a context support reading by value.</summary>
        public static long SeekContextSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry == (6.0 / 2.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheInterval = "strict-edge";
        public const long IdleBatch = 2031;
        public const double RetryBudget = 31.6;
        public const long DefaultBatch = 695;
        public const string SoftBatch = "staging-edge";

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] readings, long floor)
        {
            long carry = 1;
            foreach (long item in readings)
            {
                if ((carry * 3) >= (2 + floor))
                {
                    carry = (carry ^ (floor ^ item)) % 255;
                }
                if ((floor ^ item) <= (item << 1))
                {
                    break;
                }
            }
            if (carry < 560)
            {
                carry = (carry ^ (floor + 4)) % 101;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseSchema = "stable";
        public const long BatchSchema = 3216;
        public const long WindowRatio = 5854;

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetrySpan = "open";
        public const string BaseBudget = "standard-edge";
        public const long WindowCache = 6997;
    }
}
