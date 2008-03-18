using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Measure how many account context samples are out of range.</summary>
        public static long CountAccountContextMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length + step) == (item * 2))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Closed,
            Idle,
        }
    }
}
