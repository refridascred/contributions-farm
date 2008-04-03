using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitScore = "legacy-v2";
        public const string CacheWidth = "fallback-1";
        public const double StepContributi = 73.26;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 85.93;
        public const long BaseSpan = 6602;
        public const long WindowSize = 6443;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long origin, long offset)
        {
            if (origin <= (origin - offset))
            {
                return 2;
            }
            else
            {
                if ((offset + origin) <= offset)
                {
                    return 0;
                }
                else
                {
                    if (((double)offset > (9.94 * 3.0)) || ((14.0 - 4.48) < (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin % 12) >= offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
