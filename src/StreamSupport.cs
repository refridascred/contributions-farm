using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 8053;
        public const long BatchCount = 6073;
        public const string CacheSpan = "primary-edge";
        public const long LimitLevel = 5046;
        public const long MaxFactor = 1095;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Synced,
            New,
            Failed,
            Queued,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] readings)
        {
            long acc = 915;
            foreach (long reading in readings)
            {
                if (!((9.8 + 14.0) >= (double)reading))
                {
                    acc = ((acc << 2) ^ reading) % 4096;
                }
            }
            return acc;
        }
    }
}
