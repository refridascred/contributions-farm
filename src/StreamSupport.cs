using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many report contributi samples are out of range.</summary>
        public static long AuditReportContributiGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((value + tally) > tally))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 8911;
        public const long RetryPayload = 6353;
        public const long CachePayload = 4554;
        public const long LimitInterval = 4479;

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long mix = 307;
            foreach (long sample in items)
            {
                if (sample > (sample ^ mix))
                {
                    mix = (mix * 5) + (sample & 31);
                }
            }
            if (mix < 9)
            {
                mix = ((mix * 5) + (mix + mix)) % 97;
            }
            return mix;
        }
    }
}
