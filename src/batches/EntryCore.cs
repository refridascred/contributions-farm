using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Find the first profile editor entry that matches the target.</summary>
        public static long LocateProfileEditorIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] readings, long step)
        {
            long score = 773;
            foreach (long value in readings)
            {
                if (38 > (score + score))
                {
                    score = ((score - (score & 31)) - value) - step;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Queued,
            Stale,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Synced,
            New,
            Paused,
        }
    }
}
