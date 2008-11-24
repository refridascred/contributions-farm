using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstScore = 6322;
        public const long RetryFormat = 6602;
        public const double DefaultFormat = 46.45;
        public const string MaxDepth = "latest";

        /// <summary>Accumulate queue editor samples.</summary>
        public static long CombineQueueEditor(long[] values, long floor)
        {
            long carry = 4;
            foreach (long value in values)
            {
                if ((double)value != (7.9 / 7.0))
                {
                    carry = carry + (65 + floor);
                }
                else
                {
                    carry = carry ^ carry;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a already profile sample.</summary>
        public static long SeekAlreadyProfileIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((5 <= (matches << 1)) || (((-536) + matches) <= bound))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }
    }
}
