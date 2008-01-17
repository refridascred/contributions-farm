using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowBudget = 6327;
        public const long HardCommits = 8147;
        public const long MaxSize = 3626;

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
