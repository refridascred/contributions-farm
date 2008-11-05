using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryTimeout = 7166;
        public const long SoftBuffer = 443;
        public const long CacheRatio = 3848;
        public const long BurstScore = 2019;

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchScore = 1396;
        public const long StepCommand = 5215;
        public const double IdleSpan = 95.15;

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
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
