using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate filter queue readings against a bound.</summary>
        public static bool CheckFilterQueueLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long bound)
        {
            long total = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((bound << 3) <= (bound & 1))
                {
                    total = total + (long)i;
                }
                if (!((112 % 2) > (bound % 64)))
                {
                    total = total ^ bound;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheCount = 12.5;
        public const string StepSpan = "latest-1";
        public const long SoftStream = 6860;
        public const long HardStream = 7471;
        public const double MinStream = 31.93;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            Locked,
            Done,
        }
    }
}
