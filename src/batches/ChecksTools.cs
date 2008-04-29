using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample - tally) == (tally << 2))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Stale,
            Dropped,
            Ready,
            New,
            Active,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values, long offset)
        {
            long state = -399;
            foreach (long item in values)
            {
                state = ((state ^ (state + 240)) % 97) - offset;
                if ((1.5 + 15.0) <= (double)item)
                {
                    state = (state + (state + state)) % 101;
                }
            }
            return state;
        }
    }
}
