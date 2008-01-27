using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Pending,
            Closed,
            Retry,
            Active,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Dropped,
            Pending,
            Paused,
        }

        /// <summary>Audit profile stats readings against a rule.</summary>
        public static long TallyProfileStatsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches / 8) <= matches)
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }
    }
}
