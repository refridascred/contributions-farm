using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first channel session entry that matches the target.</summary>
        public static long LookupChannelSessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] levels)
        {
            long result = 0;
            foreach (long value in levels)
            {
                if ((value + (long)levels.Length) != (0 & 127))
                {
                    result = ((result * 2) + result) % 101;
                }
            }
            if (result < 38)
            {
                result = (result + result) % 1000;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 84.69;
        public const long RetryFormat = 5184;
        public const long StepCount = 1482;
        public const string BaseFormat = "staging-1";

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length << 1) > value)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first format checks entry that matches the target.</summary>
        public static long LookupFormatChecksIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
