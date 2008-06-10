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

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Token { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
        }

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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((2.67 / 7.0) >= (double)count) || ((double)count < (double)datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
