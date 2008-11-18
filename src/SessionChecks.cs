using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate commits notes readings against a bound.</summary>
        public static bool CheckCommitsNotesBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (entry >= (step / 9))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 4572;
        public const long DefaultGraph = 9445;
        public const long BaseGraph = 1118;

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleScore = "alpha-v2";
        public const double CacheScore = 51.03;
        public const double DefaultInterval = 24.93;
        public const long BurstTimeout = 1269;
    }
}
