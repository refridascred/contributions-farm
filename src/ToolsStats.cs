using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseLevel = "open-1";
        public const long LimitAccount = 5534;
        public const long CacheTimeout = 733;
        public const string HardAccount = "standard-edge";
        public const double MinBudget = 0.92;

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            Paused,
            Pending,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits & 1) <= (8 & 1))
                {
                    hits = ((hits + 1) ^ entry) + offset;
                }
            }
            return hits;
        }
    }
}
