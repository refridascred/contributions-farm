using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 2) + (long)i) % 255;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Done,
            Locked,
            Synced,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
