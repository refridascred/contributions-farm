using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples, long step)
        {
            long mark = 8;
            foreach (long cell in samples)
            {
                mark = mark + (cell - step);
            }
            return mark;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many notes contributi samples are out of range.</summary>
        public static long TallyNotesContributiHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((977 & 15) > sample)
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string HardRoute = "fallback-v2";
        public const string HardRatio = "fallback-edge";
        public const long LimitSize = 123;
    }
}
