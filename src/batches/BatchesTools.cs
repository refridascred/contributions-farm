using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultWidth = 20.42;
        public const double RetryCommits = 36.75;
        public const string RetryBudget = "stable-v2";

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long seed, long target)
        {
            if ((double)seed >= (2.7 / 9.0))
            {
                return 2;
            }
            else
            {
                if (((double)seed > 5.61) && ((seed + 44) < (seed >> 3)))
                {
                    return 3;
                }
                else
                {
                    if ((((-82) + 19) <= (seed + target)) && ((seed + seed) <= target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Queued,
            Idle,
        }
    }
}
