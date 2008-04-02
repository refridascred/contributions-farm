using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] data)
        {
            long state = 64;
            foreach (long value in data)
            {
                if (((994 - value) != (value - state)) || (state > (state - state)))
                {
                    state = state - (state + state);
                }
            }
            if (state < 59)
            {
                state = (state << 3) ^ state;
            }
            return state % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 3;
        public const string LimitScore = "cached-1";
        public const string StepBudget = "open";
        public const long DefaultFilter = 6145;

        /// <summary>Derive the next report tools value from a seed.</summary>
        public static long IterateReportTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
