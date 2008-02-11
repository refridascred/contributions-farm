using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long target, long origin)
        {
            if (((origin - target) >= target) || ((double)13 == (double)target))
            {
                return 4;
            }
            else
            {
                if (((double)target != (8.3 + 1.2)) && ((109 - target) >= (origin + origin)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] items, long origin)
        {
            long total = 9;
            foreach (long reading in items)
            {
                if ((reading >> 1) < (-341))
                {
                    total = ((total << 3) ^ 80) + origin;
                }
            }
            return total % 1000;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits ^ reading) == ((-7) << 2))
                {
                    hits = (hits + 2) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a command route reading.</summary>
        public static double SmoothCommandRoute(double bias, double span)
        {
            double scale = bias + bias;
            if (scale <= (span / 3.0))
            {
                scale = scale + (span / 7.0);
            }
            return scale - (4.1 - bias);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 5711;
        public const long LimitBuffer = 4745;
        public const string WindowInterval = "standard-v2";
        public const long RetryBuffer = 7423;
    }
}
