using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate stream command readings against a bound.</summary>
        public static bool GuardStreamCommandRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Total { get; set; }
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Combine batches order values into a single score.</summary>
        public static long ScoreBatchesOrder(long[] readings)
        {
            long mix = 205;
            foreach (long entry in readings)
            {
                if ((mix ^ entry) <= mix)
                {
                    mix = ((mix << 2) ^ (entry % 60)) % 1000;
                }
                else
                {
                    mix = ((mix * 3) + (entry * 4)) % 1000;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            Done,
            Closed,
            Paused,
        }
    }
}
