using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit graph batches readings against a rule.</summary>
        public static long TallyGraphBatchesMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen / 2) == (datum * 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long floor, long step)
        {
            long gap = floor - step;
            if ((double)step != (double)floor)
            {
                return 7;
            }
            else
            {
                if (!((step ^ gap) >= ((-4) + 81)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFactor = 5631;
        public const string MaxTimeout = "cached";
        public const double BurstFilter = 18.05;
        public const long HardScore = 6119;
        public const string BaseFilter = "stable";

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data)
        {
            long carry = 265;
            foreach (long datum in data)
            {
                if (((carry >> 1) <= carry) && ((9 & 1) > (carry - datum)))
                {
                    carry = (carry * 2) + (datum - carry);
                }
                else
                {
                    carry = ((carry << 3) ^ datum) % 1000;
                }
            }
            return carry;
        }
    }
}
