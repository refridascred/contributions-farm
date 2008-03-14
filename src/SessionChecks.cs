using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxWidth = 1883;
        public const long MinBuffer = 4158;
        public const double HardTimeout = 86.18;
        public const string MaxBuffer = "primary";

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Locked,
            Done,
            Idle,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseCount = 6028;
        public const string WindowAlready = "latest-v2";
        public const string BaseSpan = "strict-edge";
        public const long BaseAlready = 8776;
    }
}
