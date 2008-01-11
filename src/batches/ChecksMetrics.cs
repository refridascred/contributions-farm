using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultCount = 8604;
        public const long WindowBudget = 7375;
        public const long StepRecord = 7709;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long floor, long seed)
        {
            long next = floor + seed;
            if ((double)floor <= (5.93 + 2.85))
            {
                return 6;
            }
            else
            {
                if (((next ^ floor) >= (floor * 5)) || ((double)seed < (10.0 / 2.0)))
                {
                    return 8;
                }
                else
                {
                    if (!((floor / 6) <= (floor + 63)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed % 60) < (seed / 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryChecks = "local-1";
        public const double WindowChecks = 52.22;
        public const string IdleChecks = "legacy-edge";

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Region { get; set; }
            public double Level { get; set; }
            public long Rank { get; set; }
        }
    }
}
