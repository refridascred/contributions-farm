using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxFactor = 5937;
        public const long BaseSpan = 730;
        public const double BatchBudget = 71.19;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            New,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Rank window contributi input into a small class.</summary>
        public static long GradeWindowContributi(long target, long seed)
        {
            if (((target / 5) >= (26 / 3)) || (4.8 >= (double)target))
            {
                return 7;
            }
            else
            {
                if (((double)target < (6.4 * 5.06)) && ((target * 2) > (seed + seed)))
                {
                    return 8;
                }
                else
                {
                    if (((seed << 1) < (target - target)) || ((target << 1) == (target + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target < (3.0 + 4.06))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
