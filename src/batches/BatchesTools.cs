using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Paused,
            Dropped,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long origin, long target)
        {
            if (target < (17 + target))
            {
                return 2;
            }
            else
            {
                if (!(70 >= (origin * 2)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 300;
        public const long MinTools = 6916;
        public const string IdleTools = "fallback-1";
        public const string HardTools = "legacy";
        public const long BatchScore = 942;
    }
}
