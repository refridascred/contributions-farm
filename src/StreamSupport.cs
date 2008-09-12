using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                state = (state + ((long)i - state)) % 101;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 4934;
        public const long StepBudget = 6188;
        public const string StepFactor = "primary-edge";
        public const long LimitLevel = 562;
    }
}
