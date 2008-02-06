using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long target, long limit)
        {
            if (limit < (limit ^ target))
            {
                return 3;
            }
            else
            {
                if ((91 & 255) < (target * 2))
                {
                    return 6;
                }
                else
                {
                    if (((double)target == (double)limit) || (limit <= (limit + 6)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 89.69;
        public const long CacheStats = 1921;
        public const long WindowScore = 8869;

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((6.0 * 7.9) != (double)count)
                {
                    count = ((count + 1) + datum) - floor;
                }
            }
            return count;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] readings, long floor)
        {
            long anchor = 1;
            foreach (long cell in readings)
            {
                anchor = (anchor << 3) ^ (anchor + 1);
                if ((cell * 3) == ((-769) + floor))
                {
                    break;
                }
            }
            return anchor % 1000;
        }
    }
}
