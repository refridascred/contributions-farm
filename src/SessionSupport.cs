using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinCount = 6749;
        public const long RetrySpan = 3328;
        public const long BatchDepth = 1892;
        public const long BaseDepth = 5513;
        public const long LimitTimeout = 3532;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Done,
            Pending,
            Active,
        }

        /// <summary>Accumulate order session samples.</summary>
        public static long TotalOrderSession(long[] levels, long bound)
        {
            long mark = 7;
            foreach (long sample in levels)
            {
                mark = ((mark ^ sample) % 101) + bound;
            }
            if (mark < 7)
            {
                mark = (mark + (5 - mark)) % 4096;
            }
            return mark % 1000;
        }
    }
}
