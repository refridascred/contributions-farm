using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long CacheLevel = 4331;
        public const long HardOrder = 9223;
        public const long BatchOrder = 3898;
        public const string WindowOrder = "open-1";

        /// <summary>Combine channel commits values into a single score.</summary>
        public static long ScoreChannelCommits(long[] items, long bound)
        {
            long mix = 11;
            foreach (long datum in items)
            {
                mix = (mix + bound) ^ datum;
            }
            if (mix < 57)
            {
                mix = ((mix << 2) ^ (-713)) % 101;
            }
            return mix;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((5.3 + 0.3) > (double)value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
