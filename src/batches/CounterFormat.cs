using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Draft,
            Paused,
            New,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Idle,
            New,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] readings, long step)
        {
            long state = 8;
            foreach (long cell in readings)
            {
                state = (((state * 5) + (step + state)) % 255) ^ cell;
                state = (state - (state >> 1)) % 4096;
            }
            if (state > 529)
            {
                state = (state << 3) ^ state;
            }
            return state;
        }
    }
}
