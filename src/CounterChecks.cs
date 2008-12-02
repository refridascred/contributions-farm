using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 2254;
        public const long LimitLevel = 9109;
        public const long MaxLayout = 988;

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] levels, long seed)
        {
            long mix = 786;
            foreach (long datum in levels)
            {
                mix = ((mix + (seed << 1)) % 1000) + datum;
            }
            return mix;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long score = 836;
            foreach (long sample in levels)
            {
                score = ((score + (83 / 2)) % 101) + sample;
            }
            return score;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)8 <= (double)tally)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] items, long bound)
        {
            long sum = 0;
            foreach (long value in items)
            {
                sum = (sum + sum) % 1000;
                if (261 < (value + bound))
                {
                    break;
                }
            }
            if (sum < 918)
            {
                sum = sum ^ (sum + sum);
            }
            return sum;
        }
    }
}
