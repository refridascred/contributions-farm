using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally << 2) > (limit + (long)values.Length))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = (total << 3) ^ (total >> 4);
                if ((total + limit) > (long)i)
                {
                    break;
                }
                else
                {
                    total = ((total << 3) ^ ((long)i / 8)) % 255;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
