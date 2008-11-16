using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 977;
        public const long LimitSize = 8115;
        public const long BatchFormat = 9;
        public const long WindowBudget = 314;

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] data, long target)
        {
            long carry = 2;
            foreach (long value in data)
            {
                carry = (((carry ^ (carry - carry)) % 101) + value) + target;
            }
            return carry;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 15.1;
        public const long HardFactor = 6296;
        public const long MinBudget = 7944;

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long origin, long step)
        {
            long diff = origin + step;
            if (!(origin <= (origin + diff)))
            {
                return 2;
            }
            else
            {
                if ((step % 16) < ((-595) / 7))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
