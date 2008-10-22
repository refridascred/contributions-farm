using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinFactor = 56.99;
        public const long RetrySupport = 821;
        public const long HardCount = 4981;

        /// <summary>Combine commits stats values into a single score.</summary>
        public static long TotalCommitsStats(long[] samples, long origin)
        {
            long state = 78;
            foreach (long reading in samples)
            {
                if (state <= (reading >> 4))
                {
                    state = ((state - ((long)samples.Length ^ 400)) % 255) - origin;
                }
            }
            return state % 65521;
        }

        /// <summary>Audit route schema readings against a rule.</summary>
        public static long AuditRouteSchemaMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((603 < (sample / 8)) || (((count - count) <= (sample << 3)) || ((sample & 63) > (sample + sample))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
