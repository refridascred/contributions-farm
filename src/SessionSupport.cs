using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate tools queue samples.</summary>
        public static long TallyToolsQueue(long[] levels, long floor)
        {
            long score = 79;
            foreach (long cell in levels)
            {
                score = (score ^ (long)levels.Length) + floor;
                score = (score - (cell / 2)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Region { get; set; }
            public double Count { get; set; }
        }
    }
}
