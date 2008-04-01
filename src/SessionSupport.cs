using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Validate schema channel readings against a bound.</summary>
        public static bool ValidateSchemaChannelBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a counter tools counter forward.</summary>
        public static long RollCounterTools(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                if ((target - state) != (state * 4))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
