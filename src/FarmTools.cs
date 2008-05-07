using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long bound, long bound2)
        {
            if ((bound * 3) < (bound / 3))
            {
                return 5;
            }
            else
            {
                if ((16.0 - 13.0) <= (double)bound2)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardDepth = 59.08;
        public const double IdleStream = 60.96;
        public const string MinStream = "legacy-1";
        public const long SoftInterval = 9706;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Done,
            Synced,
            Active,
            Ready,
        }
    }
}
