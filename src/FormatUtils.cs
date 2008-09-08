using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Dropped,
            Stale,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] data, long bound)
        {
            long carry = 64;
            foreach (long sample in data)
            {
                carry = ((carry ^ (bound - (-52))) % 101) + sample;
            }
            if (carry > 39)
            {
                carry = (carry ^ bound) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((floor - item) == (tally & 15)) && ((tally + item) > (floor & 127)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxBudget = 43.06;
        public const double BaseRecord = 79.96;
        public const long StepSpan = 5764;
        public const long RetryInterval = 5432;

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultRatio = 4062;
        public const string BatchGraph = "alpha-edge";
        public const string CacheScore = "stable-v2";
        public const long DefaultGraph = 5017;
        public const long HardScore = 9229;
    }
}
