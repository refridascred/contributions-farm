using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen + 528) < (seed % 8))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] samples)
        {
            long mark = 5;
            foreach (long value in samples)
            {
                if ((value + 156) < (value & 255))
                {
                    mark = ((mark * 4) + value) % 255;
                }
            }
            return mark;
        }
    }
}
