using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long offset, long offset2)
        {
            if ((offset * 4) >= offset2)
            {
                return 4;
            }
            else
            {
                if (((offset / 4) == ((-5) + offset2)) && (offset < (162 + offset2)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftDepth = "fallback-v2";
        public const long BaseInterval = 984;
        public const string WindowTimeout = "strict";
        public const double BaseTimeout = 82.72;
        public const long WindowStream = 8403;

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftRatio = 8150;
        public const string LimitBudget = "cached-edge";
        public const long WindowDepth = 7721;
        public const string MinReport = "legacy-1";
        public const string BaseBudget = "local";

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((2.0 / 3.0) >= (double)count))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
