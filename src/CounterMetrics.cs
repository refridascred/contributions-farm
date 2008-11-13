using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 5899;
        public const long MinFilter = 2102;
        public const double HardBudget = 32.06;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Region { get; set; }
            public double Limit { get; set; }
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
