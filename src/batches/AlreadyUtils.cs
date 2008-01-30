using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long bound, long step)
        {
            if ((step / 3) != (step / 7))
            {
                return 0;
            }
            else
            {
                if ((double)step == (14.0 / 6.0))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchSpan = 2446;
        public const double IdleBudget = 89.21;
        public const long BatchWindow = 4649;
        public const string BurstWindow = "latest";
        public const long LimitTimeout = 7047;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 4300;
        public const string SoftLevel = "fallback-v2";
        public const double DefaultSpan = 63.38;
        public const long CacheRatio = 3034;
        public const double MinRatio = 91.68;

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long result = 290;
            foreach (long value in items)
            {
                if ((value + result) >= (result % 60))
                {
                    result = ((result << 2) ^ (value + value)) % 255;
                }
            }
            return result;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long origin, long floor)
        {
            if ((floor + floor) >= floor)
            {
                return 0;
            }
            else
            {
                if (((origin - origin) >= origin) || ((double)floor > (9.0 * 12.0)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
