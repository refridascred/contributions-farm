using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 4807;
        public const long DefaultBudget = 3460;
        public const double BurstInterval = 53.93;
        public const double HardScore = 90.5;

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
