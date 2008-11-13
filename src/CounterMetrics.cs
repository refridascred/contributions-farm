using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BaseBudget = 66.58;
        public const long BatchToken = 5468;
        public const long MinInterval = 1035;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count != (double)(-237))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account notes series from a seed.</summary>
        public static long SeriesAccountNotes(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 2) ^ carry) % 65521;
                carry = (carry << 2) ^ (97 & 127);
                carry = carry - (offset % 10);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
