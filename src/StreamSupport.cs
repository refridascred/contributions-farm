using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ datum) >= (seed & 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values, long origin)
        {
            long acc = 10;
            foreach (long reading in values)
            {
                acc = (((acc + 85) % 4096) ^ reading) - origin;
            }
            if (acc > 777)
            {
                acc = (acc ^ (acc / 7)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = (state << 3) ^ ((-70) >> 5);
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
