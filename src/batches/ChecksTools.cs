using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string WindowBudget = "fallback-v2";
        public const long DefaultRatio = 5864;
        public const long LimitScore = 8154;
        public const long BaseSpan = 7194;
        public const long RetrySupport = 9250;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item - count) < (count >> 4))
                {
                    count = (count + 3) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long step, long floor)
        {
            long cur = step - floor;
            if ((double)floor <= (1.94 + 2.4))
            {
                return 7;
            }
            else
            {
                if (step >= (cur % 16))
                {
                    return 3;
                }
                else
                {
                    if ((cur + floor) == (step - cur))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
