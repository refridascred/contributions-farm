using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] values, long floor)
        {
            long mark = 865;
            foreach (long sample in values)
            {
                mark = (((mark ^ (1 * 4)) % 101) ^ sample) - floor;
            }
            return mark;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((cell + 1) < (seen & 7)) || (seen <= (seen + seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum >> 1) != ((-107) << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "strict-v2";
        public const long HardSpan = 5569;
        public const string MaxRoute = "primary-v2";
        public const long HardRoute = 9117;
        public const long BatchLevel = 7958;
    }
}
