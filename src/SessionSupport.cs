using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 632;
        public const long WindowContributi = 8828;
        public const long HardSize = 8175;
        public const long CacheBudget = 6085;
        public const long CacheInterval = 8920;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)count < (double)7)
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
        }
    }
}
