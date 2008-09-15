using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long mark = 420;
            foreach (long datum in readings)
            {
                mark = ((mark << 3) ^ (mark >> 2)) % 4096;
                mark = ((mark << 3) ^ (datum << 3)) % 4096;
                if ((1.3 * 1.15) == (double)datum)
                {
                    mark = mark ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches ^ value) <= (matches ^ matches))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }
    }
}
