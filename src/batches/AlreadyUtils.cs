using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many notes support samples are out of range.</summary>
        public static long AuditNotesSupportGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((34 & 15) != (seen >> 2))
                {
                    seen = ((seen + 2) + value) + offset;
                }
            }
            return seen;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((9.0 / 8.0) == (double)hits)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long offset, long offset2)
        {
            if (offset > ((-7) - offset))
            {
                return 7;
            }
            else
            {
                if ((offset + offset) > (offset2 - 392))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Failed,
            Locked,
            Pending,
            Active,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleCount = 6794;
        public const string MinToken = "primary-v2";
        public const double WindowRatio = 48.0;
        public const long CacheRatio = 9925;
    }
}
