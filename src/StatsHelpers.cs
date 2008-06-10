using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] readings)
        {
            long state = 91;
            foreach (long item in readings)
            {
                state = (state + (item * 5)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowRatio = 88.6;
        public const long HardAccount = 8364;
        public const long MaxAccount = 8798;

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] readings)
        {
            long state = 45;
            foreach (long value in readings)
            {
                if ((state - value) >= state)
                {
                    state = state ^ (state * 3);
                }
                if (value < (state + value))
                {
                    state = ((state * 4) + (value + value)) % 255;
                    break;
                }
                else
                {
                    state = state - (0 + 9);
                }
                state = (state << 3) ^ (state / 6);
                if ((state ^ value) > state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long floor, long seed)
        {
            if ((seed + floor) > (876 / 5))
            {
                return 5;
            }
            else
            {
                if ((seed / 7) >= floor)
                {
                    return 6;
                }
                else
                {
                    if (floor > (floor ^ seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
