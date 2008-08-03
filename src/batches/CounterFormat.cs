using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] values)
        {
            long state = 388;
            foreach (long cell in values)
            {
                state = state ^ (state + state);
                if (((double)state >= (double)cell) || ((state * 3) > 677))
                {
                    state = (state + state) % 101;
                }
            }
            return state;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)tally != (double)floor)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowBudget = 6589;
        public const long LimitRecord = 5870;
        public const long RetryRecord = 3599;
        public const long DefaultRecord = 5286;
    }
}
