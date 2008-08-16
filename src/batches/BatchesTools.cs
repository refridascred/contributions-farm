using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc * 2) + (acc + 285);
                acc = (acc + (179 + acc)) % 65521;
                acc = (acc + step) % 65521;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Pending,
            Idle,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheWidth = "legacy-edge";
        public const long HardBudget = 6600;
        public const long BaseGraph = 3945;
    }
}
