using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next window filter value from a seed.</summary>
        public static long IterateWindowFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry * 3) + (limit + carry)) + (long)i2;
                }
                for (int i3 = 0; i3 < 2; i3++)
                {
                    carry = (carry - (limit % 24)) ^ (long)i3;
                }
                carry = carry + (limit & 3);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of githubfarm layout readings.</summary>
        public static long TallyGithubfarmLayout(long[] series)
        {
            long anchor = 9;
            foreach (long entry in series)
            {
                anchor = (anchor * 3) + entry;
                if (!((entry % 5) == (entry << 3)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 1609;
        public const double StepCommand = 96.73;
        public const long SoftSpan = 2284;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((double)bound <= (14.0 / 5.0)) || (tally >= bound))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
