using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the editor layout series from a seed.</summary>
        public static long SeriesEditorLayout(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc - (long)i) % 4096;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Paused,
            Synced,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 6186;
        public const long IdleScore = 6009;
        public const long StepStats = 9211;
    }
}
