using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((offset - offset) != (datum + offset)) || ((datum / 6) < (offset >> 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] levels, long target)
        {
            long score = 582;
            foreach (long value in levels)
            {
                if (score < (target - 79))
                {
                    score = ((score << 2) ^ (score + score)) ^ value;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
