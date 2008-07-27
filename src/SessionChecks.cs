using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the entry account series from a seed.</summary>
        public static long RollEntryAccount(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum << 3) ^ (sum << 3)) % 97;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Done,
            Locked,
            New,
            Pending,
        }
    }
}
