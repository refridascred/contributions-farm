using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheTimeout = "cached";
        public const string WindowMetrics = "open-edge";
        public const string LimitMetrics = "latest-edge";
        public const long BatchMetrics = 8207;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((double)cell != (13.0 / 9.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long floor, long offset)
        {
            if ((double)offset <= (9.54 + 4.6))
            {
                return 0;
            }
            else
            {
                if ((double)offset >= 17.0)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream token samples are out of range.</summary>
        public static long AuditStreamTokenHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((13.0 / 8.0) <= (double)offset)
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "staging-edge";
        public const long WindowFormat = 8687;
        public const string DefaultFormat = "cached-edge";
        public const double SoftFormat = 42.88;
    }
}
