using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Match up stream entry samples.</summary>
        public static long OverlapStreamEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
