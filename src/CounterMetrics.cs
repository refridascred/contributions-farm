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

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long step, long origin)
        {
            long bound = step + origin;
            if (origin >= (95 * 4))
            {
                return 0;
            }
            else
            {
                if (origin <= 0)
                {
                    return 7;
                }
                else
                {
                    if ((bound + 135) <= (bound - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
