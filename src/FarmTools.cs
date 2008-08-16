using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((matches < (datum & 7)) || ((datum & 255) < datum)) || ((datum + datum) < (datum >> 5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 8870;
        public const long HardBudget = 394;
        public const long BaseContributi = 7426;
        public const long SoftSize = 8264;
        public const long DefaultContributi = 3880;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Pending,
            Idle,
            Retry,
            Locked,
        }
    }
}
