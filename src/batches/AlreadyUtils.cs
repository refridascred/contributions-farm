using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every schema graph entry stays within the limit.</summary>
        public static bool VerifySchemaGraphRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate commits profile readings against a bound.</summary>
        public static bool GuardCommitsProfileBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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
