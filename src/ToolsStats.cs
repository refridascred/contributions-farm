using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Synced,
            Active,
            Closed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "primary";
        public const double HardContext = 76.96;
        public const string StepContext = "stable-edge";

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long seed, long seed2)
        {
            if ((seed2 + seed) > (seed2 / 9))
            {
                return 3;
            }
            else
            {
                if ((seed2 >> 1) != (seed / 3))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double LimitCommits = 36.84;
        public const double CacheWidth = 55.94;
        public const double BurstCommits = 19.69;
        public const string DefaultWidth = "strict-edge";
        public const string RetryCommits = "local-v2";

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Done,
            Retry,
            Locked,
            Active,
        }
    }
}
