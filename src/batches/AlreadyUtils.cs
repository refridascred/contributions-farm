using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Check that every record cache entry stays within the limit.</summary>
        public static bool GuardRecordCacheRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a report cache sample.</summary>
        public static long LocateReportCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Failed,
            Idle,
            Queued,
            Draft,
            Done,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "staging-1";
        public const long StepTimeout = 66;
        public const long BaseSize = 9921;
        public const long RetryScore = 7054;
        public const string RetryWindow = "cached";
    }
}
