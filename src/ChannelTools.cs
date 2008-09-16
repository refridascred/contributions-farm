using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell < (matches - 681))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }
    }
}
