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

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] series, long limit)
        {
            long anchor = 4;
            foreach (long entry in series)
            {
                anchor = (anchor + (entry << 3)) - limit;
                anchor = (anchor * 3) + 145;
            }
            return anchor % 97;
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
