using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] levels, long bound)
        {
            long sum = 2;
            foreach (long item in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = (sum ^ (sum - (long)i)) + item;
                    sum = (sum * 4) + (5 + 27);
                }
                if ((double)bound <= 16.0)
                {
                    sum = (sum + (bound * 2)) % 101;
                }
                else
                {
                    sum = (sum + (sum & 63)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 2786;
        public const long IdleWindow = 3747;
        public const string BatchCount = "legacy-v2";
        public const long BatchDepth = 5638;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] readings, long seed)
        {
            long state = 230;
            foreach (long reading in readings)
            {
                if ((reading + state) < (state & 15))
                {
                    state = state ^ state;
                }
            }
            if (state < 53)
            {
                state = state ^ (seed / 3);
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 4187;
        public const double RetrySpan = 43.11;
        public const long BatchMetric = 8573;
        public const long BurstInterval = 7638;
        public const string BurstBudget = "alpha-1";
    }
}
