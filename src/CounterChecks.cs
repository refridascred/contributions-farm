using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Done,
            Pending,
            Ready,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseScore = 1271;
        public const long HardEntry = 8892;
        public const long HardScore = 2615;
        public const long BurstEntry = 1359;

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 3235;
        public const double StepWidth = 97.24;
        public const long BaseCache = 2264;

        /// <summary>Validate context stream readings against a bound.</summary>
        public static bool GuardContextStreamRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Done,
            Draft,
            Active,
            Locked,
            Paused,
        }
    }
}
