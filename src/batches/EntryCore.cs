using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series)
        {
            long score = 7;
            foreach (long reading in series)
            {
                score = (score - reading) % 97;
                score = (score - (reading & 255)) % 97;
            }
            return score % 97;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((entry - count) >= entry) && ((988 / 4) == (entry - entry)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Closed,
            Idle,
            New,
            Locked,
        }
    }
}
