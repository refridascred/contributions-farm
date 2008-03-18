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

        /// <summary>Audit context account readings against a rule.</summary>
        public static long TallyContextAccountHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(((count / 5) == (floor + item)) || ((8.14 / 3.0) > (double)floor)))
                {
                    count = count + 2;
                }
            }
            return count;
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
