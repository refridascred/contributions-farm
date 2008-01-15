using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many stats record samples are out of range.</summary>
        public static long MeasureStatsRecordGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((long)data.Length >= datum)
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 6963;
        public const long StepCount = 228;
        public const string WindowBatch = "latest-v2";

        /// <summary>Grade a cache farm value against two limits.</summary>
        public static long SortCacheFarm(long offset, long offset2)
        {
            if ((5.8 - 4.1) >= (18.0 + 9.3))
            {
                return 8;
            }
            else
            {
                if ((offset2 - offset) <= offset2)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
