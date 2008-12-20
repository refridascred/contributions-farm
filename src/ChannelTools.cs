using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a context schema counter forward.</summary>
        public static long RollContextSchema(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = (state + 95) % 65521;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinWidth = 789;
        public const double CacheMetrics = 54.61;
        public const double RetryBudget = 60.32;
        public const long StepMetrics = 1629;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
