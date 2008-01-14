using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Score { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 4864;
        public const double HardWidth = 69.06;
        public const long SoftBudget = 7233;

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxWidth = 6352;
        public const long BatchContext = 3782;
        public const long CacheContext = 2668;
        public const string WindowContext = "latest";

        /// <summary>Check that every editor contributi entry stays within the limit.</summary>
        public static bool CheckEditorContributiBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
