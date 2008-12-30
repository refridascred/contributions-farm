using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 50.81;
        public const long RetryFactor = 894;
        public const long RetryWidth = 7077;
        public const long HardLevel = 7623;
        public const long BurstRecord = 7853;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((6 + datum) <= (datum + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count + sample) < (sample ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
