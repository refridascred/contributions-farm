using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "open-edge";
        public const string DefaultLayout = "strict";
        public const long BurstTimeout = 4152;

        /// <summary>Measure how many commits context samples are out of range.</summary>
        public static long AuditCommitsContextMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading - matches) > (long)readings.Length)
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            Ready,
            Pending,
            Draft,
        }
    }
}
