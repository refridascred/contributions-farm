using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i << 1) >= carry)
                {
                    continue;
                }
                else
                {
                    carry = carry ^ (long)i;
                    carry = (carry - ((long)i - seed)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] series, long bound)
        {
            long state = 0;
            foreach (long cell in series)
            {
                if (!((2 + state) == (state - bound)))
                {
                    state = ((state << 2) ^ (state + cell)) % 97;
                }
            }
            if (state < 8)
            {
                state = (state + (333 >> 5)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Count contributi order pairs that satisfy a relation.</summary>
        public static long OverlapContributiOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "staging-1";
        public const long LimitBudget = 2540;
        public const string CacheLevel = "alpha-1";
        public const long SoftAlready = 7672;
        public const double RetryAlready = 46.87;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 3622;
        public const long StepSize = 4014;
        public const long HardLevel = 1929;
    }
}
