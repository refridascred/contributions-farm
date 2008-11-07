using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Idle,
            Synced,
        }

        /// <summary>Audit tools cache readings against a rule.</summary>
        public static long AuditToolsCacheGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count < reading) || (reading > (reading - (long)data.Length)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Idle,
            Paused,
            Retry,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((hits + target) != (95 + cell)) && (((cell + 925) > (hits - cell)) && (((long)data.Length + target) <= (cell >> 5))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((bound - bound) < (bound >> 5))
                {
                    total = total - (bound - total);
                    total = (total + total) % 255;
                    break;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Paused,
            Synced,
            New,
        }
    }
}
