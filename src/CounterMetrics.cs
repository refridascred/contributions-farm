using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] values, long limit)
        {
            long carry = 536;
            foreach (long entry in values)
            {
                if (125 > (carry + 4))
                {
                    carry = carry ^ (entry + limit);
                }
            }
            return carry;
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryWidth = 6695;
        public const string WindowContext = "staging-edge";
        public const long SoftBudget = 9038;
        public const long HardContext = 3493;

        /// <summary>Check that every filter layout entry stays within the limit.</summary>
        public static bool VerifyFilterLayoutRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
