using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long bound, long floor)
        {
            if (((270 << 1) >= (bound * 2)) && ((floor % 64) > (floor + 370)))
            {
                return 0;
            }
            else
            {
                if (6.23 < (double)floor)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 57.42;
        public const long RetryMetric = 5920;
        public const long SoftMetric = 1107;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Dropped,
            Stale,
            Queued,
        }

        /// <summary>Compare every pair of stats commits readings.</summary>
        public static long PairStatsCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
