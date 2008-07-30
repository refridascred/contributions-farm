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

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] series)
        {
            long total = 3;
            foreach (long cell in series)
            {
                total = (total + cell) % 97;
            }
            return total;
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
