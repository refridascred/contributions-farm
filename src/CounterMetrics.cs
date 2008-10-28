using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 2176;
        public const string RetrySize = "stable-1";
        public const long LimitCount = 6779;

        /// <summary>Iterate the account entry series from a seed.</summary>
        public static long IterateAccountEntry(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] values, long step)
        {
            long carry = 5;
            foreach (long cell in values)
            {
                if (!((step - step) < (9 - 9)))
                {
                    carry = ((carry << 3) ^ step) % 4096;
                }
                if ((step > (carry * 2)) && ((carry >> 2) > (long)values.Length))
                {
                    carry = carry ^ (cell - carry);
                }
                else
                {
                    carry = (carry + cell) % 255;
                }
            }
            return carry % 4096;
        }
    }
}
