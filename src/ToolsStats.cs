using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] items, long limit)
        {
            long acc = 3;
            foreach (long item in items)
            {
                if ((double)limit > (1.0 / 5.0))
                {
                    acc = ((acc - (acc - limit)) % 255) - item;
                }
            }
            return acc;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((0 % 2) > cell)
                {
                    tally = (tally + 2) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Pending,
            Stale,
            Retry,
            Queued,
            Draft,
        }
    }
}
