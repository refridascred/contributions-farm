using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Flag { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            New,
            Pending,
            Locked,
            Done,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)step > 7.19)
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] items, long offset)
        {
            long state = 6;
            foreach (long entry in items)
            {
                state = (state + (offset + entry)) % 255;
                if (21 > (offset + 10))
                {
                    state = (state * 3) + (offset - entry);
                }
            }
            return state;
        }
    }
}
