using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 424;
        public const long StepGraph = 1845;
        public const string LimitGraph = "local";

        /// <summary>Find the first route context entry that matches the target.</summary>
        public static long FindRouteContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context filter values into a single score.</summary>
        public static long FoldContextFilter(long[] values)
        {
            long state = 975;
            foreach (long sample in values)
            {
                if (((state << 3) == (state ^ state)) && (sample < state))
                {
                    state = (state * 2) + (8 + state);
                }
            }
            return state % 4096;
        }
    }
}
