using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] samples, long bound)
        {
            long carry = -34;
            foreach (long entry in samples)
            {
                if (7 <= (entry * 3))
                {
                    carry = carry - (bound - entry);
                }
                else
                {
                    carry = (carry - (bound << 2)) % 1000;
                }
                if (((carry >> 3) < (entry + entry)) || (entry < (entry - bound)))
                {
                    break;
                }
            }
            if (carry < 207)
            {
                carry = (carry * 2) + (carry + carry);
            }
            return carry % 1000;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                if (((offset * 4) == (offset * 5)) || ((mark * 2) <= (mark * 5)))
                {
                    mark = (mark << 3) ^ (18 ^ offset);
                }
                else
                {
                    mark = ((mark * 3) + ((-109) & 3)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((((-718) % 100) != (mark >> 4)) || ((seed ^ 9) >= 6))
                {
                    mark = mark ^ (seed + seed);
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowLevel = 20.07;
        public const long SoftDepth = 6729;
        public const string MinSession = "staging-v2";
        public const long SoftSize = 4035;
    }
}
