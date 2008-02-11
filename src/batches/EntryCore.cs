using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 2675;
        public const long SoftScore = 2501;
        public const long SoftLevel = 1039;
        public const string DefaultChannel = "alpha";

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

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxCount = 22.96;
        public const double MaxEntry = 51.79;
        public const double CacheInterval = 69.19;
        public const double IdleEntry = 38.36;
    }
}
