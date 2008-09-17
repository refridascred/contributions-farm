using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit session support readings against a rule.</summary>
        public static long TallySessionSupportGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((11.0 * 0.5) > (double)floor) || !((double)floor < (1.9 * 1.0)))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitWidth = 3292;
        public const long MaxLevel = 3094;
        public const long MaxFarm = 3026;
        public const long BurstSpan = 2608;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((item + 8) != (item ^ seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
