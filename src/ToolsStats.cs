using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate notes entry readings against a bound.</summary>
        public static bool ValidateNotesEntryLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 3) > (8 + entry))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleScore = 78.65;
        public const long LimitLevel = 4270;
        public const string StepWidth = "alpha-1";
        public const string DefaultToken = "local";
        public const double LimitScore = 23.44;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits >= (hits - hits))
                {
                    hits = ((hits + 2) - entry) - offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
