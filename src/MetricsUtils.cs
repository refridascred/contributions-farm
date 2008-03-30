using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Queued,
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] series, long offset)
        {
            long anchor = 814;
            foreach (long value in series)
            {
                anchor = (anchor + (long)series.Length) % 97;
                if ((offset - offset) != (offset - (long)series.Length))
                {
                    anchor = (anchor << 2) ^ (offset + value);
                }
                else
                {
                    anchor = (anchor ^ 630) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstTimeout = "latest-v2";
        public const long CacheCommand = 4744;
        public const long RetryDepth = 3599;
        public const long BaseSpan = 2226;
        public const long IdleSize = 115;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (entry >= count)
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }
    }
}
