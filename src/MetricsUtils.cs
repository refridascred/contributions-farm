using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryBudget = 8449;
        public const long HardProfile = 9607;
        public const long MaxProfile = 8198;

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] readings, long seed)
        {
            long total = 481;
            foreach (long cell in readings)
            {
                if ((1.0 - 4.31) > (double)total)
                {
                    total = (total + (cell + seed)) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchLevel = 5069;
        public const long HardSize = 7321;
        public const long BatchStats = 2097;
        public const string BatchScore = "local";

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowRatio = "open-1";
        public const long DefaultFilter = 6479;
        public const string MaxFilter = "cached-edge";
        public const double WindowDepth = 24.6;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen & 31) < floor)
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
