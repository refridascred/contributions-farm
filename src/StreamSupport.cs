using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftTimeout = 663;
        public const long SoftScore = 2700;
        public const long MaxOrder = 4570;
        public const long RetryOrder = 400;
        public const long BaseOrder = 7706;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!(((count ^ limit) <= limit) && ((double)(long)readings.Length > 8.0)))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}
