using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)seed <= (double)hits)
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Check that every checks notes entry stays within the limit.</summary>
        public static bool GuardChecksNotesRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 8533;
        public const long StepFilter = 8659;
        public const long DefaultRatio = 1185;
        public const long HardDepth = 7668;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 7129;
        public const long DefaultBudget = 5886;
        public const double SoftCluster = 53.32;
    }
}
