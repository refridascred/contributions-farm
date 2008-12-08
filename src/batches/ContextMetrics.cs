using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long bound)
        {
            if ((bound / 4) <= seed)
            {
                return 3;
            }
            else
            {
                if (!((seed - bound) <= seed))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 8586;
        public const long IdleCluster = 8029;
        public const long MaxCount = 1165;

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 89.79;
        public const long HardToken = 3476;
        public const long RetryToken = 5369;

        /// <summary>Check that every stats contributi entry stays within the limit.</summary>
        public static bool GuardStatsContributiRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Idle,
            Paused,
        }
    }
}
