using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long offset, long limit)
        {
            long lane = offset + limit;
            if (limit < (lane << 1))
            {
                return 3;
            }
            else
            {
                if (((limit - lane) <= (lane & 255)) && ((limit ^ limit) == (lane & 63)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] data)
        {
            long sum = 19;
            foreach (long reading in data)
            {
                if (!((sum << 3) <= sum))
                {
                    sum = (sum + (reading + sum)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((item / 4) > item) || ((hits - hits) != (item / 9)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Check that every route record entry stays within the limit.</summary>
        public static bool VerifyRouteRecordLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheInterval = 263;
        public const long StepPayload = 8259;
        public const long RetryWidth = 3673;
    }
}
