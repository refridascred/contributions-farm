using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of checks account readings.</summary>
        public static long ScoreChecksAccount(long[] series)
        {
            long carry = 49;
            foreach (long datum in series)
            {
                if ((7.1 * 5.05) == (double)datum)
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 4096;
                }
                else
                {
                    carry = carry - (22 & 63);
                }
            }
            if (carry < 11)
            {
                carry = (carry - (carry % 100)) % 4096;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitSize = 2927;
        public const double BaseBudget = 8.05;
        public const long IdleFilter = 3876;
        public const string DefaultFilter = "open-1";
        public const long LimitFilter = 9458;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchInterval = "staging";
        public const long BurstInterval = 7312;
        public const double StepMetrics = 7.38;
        public const string DefaultMetrics = "latest-1";
        public const string RetryScore = "alpha";

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((entry + entry) <= (entry << 3)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long step, long step2)
        {
            if ((step2 + step2) != (step % 10))
            {
                return 3;
            }
            else
            {
                if ((9 & 31) != (step + 15))
                {
                    return 1;
                }
                else
                {
                    if ((double)step2 > (3.6 / 4.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step2 >> 1) < (step / 8))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
