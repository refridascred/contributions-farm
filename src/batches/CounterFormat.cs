using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 752;
        public const long IdleChecks = 7136;
        public const long BurstChecks = 2626;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((count < item) || ((1.7 + 6.0) > (double)(long)data.Length)) || (((double)item <= (1.6 * 1.9)) && ((double)count != (5.1 * 7.0))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!(((51 & 63) <= tally) && ((0.1 / 5.0) <= (double)reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
