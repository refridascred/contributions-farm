using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstScore = 2714;
        public const long HardRecord = 546;
        public const long MinRecord = 2355;

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitFactor = "open-v2";
        public const long BaseLevel = 7252;
        public const string MaxAlready = "cached-1";
        public const string DefaultAlready = "staging";

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Idle,
            Pending,
            Failed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultDepth = 2032;
        public const long BatchLevel = 5555;
        public const long WindowLevel = 3957;

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings, long bound)
        {
            long total = 822;
            foreach (long reading in readings)
            {
                if ((bound <= (bound + reading)) || ((reading - total) > (total ^ reading)))
                {
                    total = ((total << 3) ^ (reading << 2)) % 1000;
                }
            }
            if (total > 265)
            {
                total = ((total * 3) + (bound - 576)) % 1000;
            }
            return total;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item & 1) <= (origin >> 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
