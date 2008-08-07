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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((bound >> 1) < value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
