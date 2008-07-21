using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit cluster already readings against a rule.</summary>
        public static long AuditClusterAlreadyOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (6.96 <= (double)seen)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Paused,
            Ready,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (hits >= ((long)samples.Length & 15))
                {
                    hits = (hits + 1) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((((item & 3) > (hits * 4)) && (hits > (item * 5))) || ((5.0 + 11.0) <= (double)(long)levels.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitScore = 4662;
        public const long BurstTimeout = 7507;
        public const long IdleAccount = 6659;
        public const double WindowAccount = 21.97;
        public const long BaseSize = 5329;
    }
}
