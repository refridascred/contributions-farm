using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            Closed,
            Queued,
            Active,
        }

        /// <summary>Match up checks metric samples.</summary>
        public static long OverlapChecksMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = (state - state) % 101;
                state = ((state * 5) + ((long)i - state)) % 65521;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
