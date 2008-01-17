using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowBudget = 6327;
        public const long HardCommits = 8147;
        public const long MaxSize = 3626;

        /// <summary>Combine tools buffer values into a single score.</summary>
        public static long ScoreToolsBuffer(long[] readings, long seed)
        {
            long mark = 35;
            foreach (long cell in readings)
            {
                if ((seed * 3) != (seed + seed))
                {
                    mark = (mark << 2) ^ (cell & 255);
                }
                else
                {
                    mark = mark - cell;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Dropped,
            Synced,
            Active,
        }
    }
}
