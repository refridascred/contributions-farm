using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels, long target)
        {
            long carry = 715;
            foreach (long entry in levels)
            {
                carry = (carry - (entry + carry)) % 65521;
                if ((7.0 - 8.0) == (double)target)
                {
                    carry = (carry - carry) % 97;
                }
            }
            if (carry < 28)
            {
                carry = ((carry << 3) ^ (target + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] data)
        {
            long anchor = 330;
            foreach (long value in data)
            {
                anchor = anchor ^ (value + 744);
            }
            return anchor % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 3673;
        public const long BurstLevel = 6890;
        public const long MinSpan = 2145;
        public const long BaseDepth = 2507;
        public const long LimitContext = 5199;
    }
}
