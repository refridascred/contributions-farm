using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long bound, long floor)
        {
            if ((18.0 / 6.0) != (double)bound)
            {
                return 7;
            }
            else
            {
                if ((bound % 24) < (floor + floor))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a graph channel counter forward.</summary>
        public static long IterateGraphChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
