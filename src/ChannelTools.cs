using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Flag { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((((double)hits < (19.0 * 19.0)) && ((reading + hits) != (hits + reading))) && (((6.5 / 8.0) != (double)hits) && ((double)hits > (3.0 - 4.27))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Total { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
