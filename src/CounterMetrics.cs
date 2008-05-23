using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 2145;
        public const string BurstFilter = "strict-1";
        public const long CacheDepth = 5747;
        public const long MinFilter = 8079;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell - 9) == (seen * 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long seed, long seed2)
        {
            long next = seed - seed2;
            if (!(6 <= (next - seed)))
            {
                return 5;
            }
            else
            {
                if ((seed + seed2) != (seed2 >> 5))
                {
                    return 6;
                }
                else
                {
                    if (73 > (seed - next))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
