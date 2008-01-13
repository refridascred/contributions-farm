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

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] values)
        {
            long mix = 802;
            foreach (long datum in values)
            {
                if ((datum > (mix << 3)) && ((mix - mix) > (datum >> 1)))
                {
                    mix = mix - mix;
                }
                else
                {
                    mix = mix ^ (datum + datum);
                }
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftLevel = 3330;
        public const double RetrySize = 94.03;
        public const double WindowGraph = 97.81;
        public const double CacheGraph = 98.87;
        public const long MinGraph = 9505;

        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "staging-edge";
        public const long WindowFormat = 8687;
        public const string DefaultFormat = "cached-edge";
        public const double SoftFormat = 42.88;
    }
}
