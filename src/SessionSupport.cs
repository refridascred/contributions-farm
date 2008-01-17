using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 9521;
        public const long DefaultRatio = 5350;
        public const long LimitGraph = 9517;
        public const long BaseGraph = 1426;

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long offset, long offset2)
        {
            if (3 >= offset2)
            {
                return 5;
            }
            else
            {
                if (((double)offset <= (2.0 - 18.0)) || ((offset2 * 2) >= (offset2 >> 2)))
                {
                    return 3;
                }
                else
                {
                    if ((offset2 + offset2) <= (offset - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
