using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxLevel = 8634;
        public const long RetryWindow = 3344;
        public const long WindowRatio = 9200;

        /// <summary>Count the entry filter entries that pass the check.</summary>
        public static long TallyEntryFilterHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value & 31) < (seen * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
