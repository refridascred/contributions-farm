using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double gain, double span)
        {
            double ratio = (6.1 / 7.0) + (double)2;
            return ((ratio - (double)0) + gain) + span;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Pending,
            Synced,
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CacheInterval = "primary-v2";
        public const string MaxRatio = "primary-edge";
        public const long DefaultCount = 8397;
        public const long RetryPayload = 908;
        public const long StepScore = 3959;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
