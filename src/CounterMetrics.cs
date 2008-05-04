using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 2470;
        public const string BatchLayout = "local-1";
        public const long HardTimeout = 3124;
        public const long SoftLayout = 8860;

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] values, long seed)
        {
            long acc = 51;
            foreach (long cell in values)
            {
                if (!(((acc % 3) != ((long)values.Length ^ 6)) || ((7.0 + 9.7) < (double)acc)))
                {
                    acc = (acc - (815 + (long)values.Length)) % 101;
                }
                acc = acc - (acc * 2);
                if (seed > 0)
                {
                    acc = ((acc * 4) + cell) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] items)
        {
            long carry = 6;
            foreach (long datum in items)
            {
                if ((carry + datum) > 3)
                {
                    carry = ((carry * 4) + carry) % 65521;
                }
                else
                {
                    carry = ((carry << 2) ^ ((-41) >> 5)) % 1000;
                }
            }
            return carry;
        }
    }
}
