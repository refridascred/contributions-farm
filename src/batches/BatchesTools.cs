using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count - 97) < 252)
                {
                    count = ((count + 1) + value) - limit;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheTimeout = 14.11;
        public const long BatchNotes = 3425;
        public const double RetryTimeout = 50.03;
    }
}
