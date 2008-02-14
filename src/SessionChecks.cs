using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepFactor = 5286;
        public const long BurstCounter = 9176;
        public const long CacheCount = 4235;

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally < (target % 24)) && (entry < (target << 1)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every filter metrics entry stays within the limit.</summary>
        public static bool GuardFilterMetricsLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            New,
            Synced,
            Closed,
        }
    }
}
