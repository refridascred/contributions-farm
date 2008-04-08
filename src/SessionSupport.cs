using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value % 24) <= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 70.03;
        public const long RetryScore = 5607;
        public const long StepNotes = 8991;
        public const long SoftLevel = 6787;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
