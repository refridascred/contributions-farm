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

        /// <summary>Accumulate window command samples.</summary>
        public static long TotalWindowCommand(long[] series, long target)
        {
            long mix = 4;
            foreach (long sample in series)
            {
                mix = (mix + mix) % 97;
                if (((4.6 / 3.0) <= (double)target) && ((target % 7) <= sample))
                {
                    mix = (mix + target) % 4096;
                }
            }
            if (mix > 87)
            {
                mix = mix - (target * 2);
            }
            return mix % 65521;
        }
    }
}
