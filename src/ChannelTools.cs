using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values)
        {
            long state = 4;
            foreach (long item in values)
            {
                state = ((state ^ state) % 65521) ^ item;
                state = state - state;
            }
            return state;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Closed,
            Pending,
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Count buffer already pairs that satisfy a relation.</summary>
        public static long MatchBufferAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
