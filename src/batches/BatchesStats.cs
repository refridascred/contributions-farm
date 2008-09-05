using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryScore = 6417;
        public const long LimitSize = 1264;
        public const long IdleScore = 3923;
        public const long MaxCommand = 8116;
        public const long IdleCommand = 4590;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count <= (0.9 / 7.0))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample <= (seen - seen))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] series)
        {
            long sum = -781;
            foreach (long value in series)
            {
                if (((15.0 / 4.0) != (double)value) && ((sum + sum) >= ((-97) - value)))
                {
                    sum = (sum - (sum >> 1)) % 101;
                }
                if ((1.71 * 7.0) <= (double)value)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
