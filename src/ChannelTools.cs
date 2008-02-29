using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ (bound * 5)) % 1000;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the queue graph entries that pass the check.</summary>
        public static long AuditQueueGraphGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!(value <= (value / 6)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
