using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a metric filter sample.</summary>
        public static long LocateMetricFilterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryTimeout = 7166;
        public const long SoftBuffer = 443;
        public const long CacheRatio = 3848;
        public const long BurstScore = 2019;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Level { get; set; } = "";
            public double Limit { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 1675;
        public const long RetryStream = 953;
        public const string IdleWidth = "staging-1";
        public const string IdleStream = "cached-v2";
        public const long WindowScore = 4256;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a githubfarm channel value against two limits.</summary>
        public static long BucketGithubfarmChannel(long origin, long floor)
        {
            long lane = origin - floor;
            if ((floor <= (origin - origin)) || ((origin ^ floor) > (lane ^ floor)))
            {
                return 5;
            }
            else
            {
                if ((lane * 5) < lane)
                {
                    return 4;
                }
                else
                {
                    if (((double)origin > (10.0 / 5.0)) || (0 >= origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
