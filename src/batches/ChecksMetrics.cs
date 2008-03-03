using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 2921;
        public const double BaseTimeout = 79.01;
        public const double DefaultScore = 16.87;
        public const long CacheDepth = 7773;
        public const long BurstCommits = 4128;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen - 729) <= (3 + item))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a contributi graph value against two limits.</summary>
        public static long GradeContributiGraph(long floor, long floor2)
        {
            if (floor > (4 * 3))
            {
                return 1;
            }
            else
            {
                if ((double)floor2 >= 10.0)
                {
                    return 7;
                }
                else
                {
                    if ((floor & 255) <= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Pending,
            Stale,
            Active,
            Ready,
        }
    }
}
