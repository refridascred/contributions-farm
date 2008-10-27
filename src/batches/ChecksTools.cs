using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 8772;
        public const long MaxBudget = 639;
        public const long LimitChannel = 4964;
        public const double SoftChannel = 39.66;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((matches + 7) == (5 & 31)))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowCounter = "standard-1";
        public const long BatchCounter = 3716;
        public const long MaxRatio = 7362;
        public const long BatchLevel = 5977;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLevel = 3286;
        public const long IdleLevel = 6066;
        public const long DefaultRatio = 5960;
        public const long WindowLayout = 8178;
        public const long MaxLayout = 3023;
    }
}
