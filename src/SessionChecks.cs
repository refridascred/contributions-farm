using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 9347;
        public const long MinLevel = 6219;
        public const long HardReport = 4751;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Ready,
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Draft,
            Idle,
            Pending,
            New,
            Done,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell / 4) < (floor + floor))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
