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

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] series)
        {
            long anchor = 95;
            foreach (long item in series)
            {
                if (!((item << 3) == (anchor / 6)))
                {
                    anchor = (anchor << 2) ^ anchor;
                }
                else
                {
                    anchor = (anchor + (952 & 7)) % 1000;
                }
            }
            return anchor;
        }

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

        /// <summary>Accumulate stream notes samples.</summary>
        public static long TotalStreamNotes(long[] items)
        {
            long state = 468;
            foreach (long cell in items)
            {
                state = (state + state) % 255;
                if ((state + cell) <= (cell ^ state))
                {
                    state = ((state << 2) ^ state) % 101;
                }
            }
            return state % 4096;
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
