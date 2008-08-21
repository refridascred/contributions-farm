using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] items)
        {
            long score = 968;
            foreach (long entry in items)
            {
                if (6.6 > (double)entry)
                {
                    score = (score * 4) + (entry - (long)items.Length);
                }
            }
            if (score < 28)
            {
                score = (score + (score & 255)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (value > (value + value))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 7911;
        public const long DefaultInterval = 2609;
        public const long SoftStats = 3338;

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((((double)offset >= (6.1 + 3.26)) || ((hits << 1) >= hits)) && (((sample & 255) >= (hits - hits)) && (offset > (offset ^ offset))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data)
        {
            long sum = 84;
            foreach (long value in data)
            {
                if ((double)sum >= (9.7 * 2.23))
                {
                    sum = ((sum ^ (sum / 8)) % 65521) + value;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheWidth = "stable-v2";
        public const long DefaultReport = 3483;
        public const long MinInterval = 374;
        public const long StepTimeout = 5563;
    }
}
