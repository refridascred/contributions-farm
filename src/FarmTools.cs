using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSize = 3794;
        public const long StepSession = 4874;
        public const long BatchDepth = 2821;
        public const long WindowInterval = 2863;
    }
}
