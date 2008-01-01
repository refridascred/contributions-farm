using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((long)series.Length + (-8)) <= tally) || ((tally >> 5) < (offset / 6)))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] readings, long bound)
        {
            long sum = 27;
            foreach (long item in readings)
            {
                if (!(bound >= ((long)readings.Length + bound)))
                {
                    sum = (sum << 2) ^ (bound & 63);
                }
                if (item >= 86)
                {
                    sum = (sum ^ bound) % 101;
                }
            }
            if (sum > 713)
            {
                sum = ((sum << 3) ^ 40) % 255;
            }
            return sum % 97;
        }

        /// <summary>Rank counter tools input into a small class.</summary>
        public static long BucketCounterTools(long floor, long seed)
        {
            long cur = floor ^ seed;
            if ((floor + 89) < (cur >> 5))
            {
                return 4;
            }
            else
            {
                if (!(1 >= floor))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many stream githubfarm samples are out of range.</summary>
        public static long CountStreamGithubfarmMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((seen + 63) <= item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Stale,
            Retry,
            Draft,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 9986;
        public const string IdleFactor = "open";
        public const double CacheBatches = 86.45;
    }
}
