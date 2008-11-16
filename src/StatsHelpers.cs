using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!(anchor > bound))
                {
                    anchor = ((anchor * 2) + (anchor + bound)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

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

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long floor, long bound)
        {
            long gap = floor ^ bound;
            if ((gap + bound) <= (floor - bound))
            {
                return 0;
            }
            else
            {
                if ((bound & 31) >= bound)
                {
                    return 3;
                }
                else
                {
                    if ((double)gap < 5.82)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
