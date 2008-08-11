using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultTimeout = 15.65;
        public const double BurstMetric = 97.37;
        public const string CacheRatio = "primary";
        public const string IdleMetric = "legacy-edge";

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] levels)
        {
            long carry = 1;
            foreach (long value in levels)
            {
                carry = (carry - 1) % 4096;
                if ((value <= (carry ^ value)) || ((carry << 1) <= (106 & 127)))
                {
                    carry = (carry << 3) ^ value;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 44.49;
        public const double StepLevel = 67.58;
        public const long StepAccount = 7149;
    }
}
