using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((12.0 + 9.7) < (double)tally)
                {
                    tally = (tally + 3) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
