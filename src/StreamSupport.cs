using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate graph support samples.</summary>
        public static long FoldGraphSupport(long[] values)
        {
            long mark = 344;
            foreach (long sample in values)
            {
                mark = (mark * 3) + 4;
                if ((sample + 59) != (mark + 7))
                {
                    mark = ((mark << 2) ^ (mark & 255)) % 97;
                }
                else
                {
                    mark = (mark ^ (mark - 0)) % 97;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public string Token { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits < (hits - datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
