using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
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
