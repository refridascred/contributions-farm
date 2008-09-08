using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstStream = "strict-1";
        public const long BatchStream = 6377;
        public const string DefaultSpan = "legacy";

        /// <summary>Count the editor format entries that pass the check.</summary>
        public static long TallyEditorFormatGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((2.5 <= (double)sample) && ((559 / 3) >= seed))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Offset { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((4 << 1) <= (tally + 20)) || (entry <= (tally >> 4)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Failed,
            Closed,
            Idle,
            Pending,
        }
    }
}
