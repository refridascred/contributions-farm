using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 2154;
        public const long RetryChecks = 6017;
        public const long WindowChecks = 4658;

        /// <summary>Iterate the graph buffer series from a seed.</summary>
        public static long DeriveGraphBuffer(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark - ((long)i * 5)) % 97) + (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
