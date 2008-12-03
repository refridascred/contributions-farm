using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

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

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] items, long floor)
        {
            long result = 467;
            foreach (long sample in items)
            {
                result = result + 316;
                if ((floor & 31) <= (sample % 8))
                {
                    result = (result - sample) % 4096;
                }
                else
                {
                    result = (result - (result - 633)) % 97;
                }
            }
            if (result < 7)
            {
                result = (result + (result + floor)) % 97;
            }
            return result;
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
