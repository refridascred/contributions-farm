using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] levels, long seed)
        {
            long state = -7;
            foreach (long entry in levels)
            {
                if ((state - 40) > (state + 11))
                {
                    state = (((state * 3) + (state ^ seed)) % 101) + entry;
                }
                else
                {
                    state = ((state << 3) ^ (long)levels.Length) % 65521;
                }
            }
            if (state > 542)
            {
                state = (state << 2) ^ (56 + 965);
            }
            return state;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
