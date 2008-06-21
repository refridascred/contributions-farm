using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowBudget = 7659;
        public const double BatchWindow = 77.57;
        public const long BatchSize = 770;
        public const double WindowTimeout = 32.17;

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long limit, long seed)
        {
            if ((double)seed > (8.8 - 4.0))
            {
                return 7;
            }
            else
            {
                if (((limit % 97) == (seed - seed)) || ((seed & 1) > (limit * 4)))
                {
                    return 0;
                }
                else
                {
                    if ((1.3 - 9.82) != (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
