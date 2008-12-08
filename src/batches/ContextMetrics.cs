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

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

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
