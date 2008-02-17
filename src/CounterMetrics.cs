using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long floor, long step)
        {
            long next = floor - step;
            if (((next & 255) == (floor / 3)) && ((50 % 8) > (next ^ next)))
            {
                return 7;
            }
            else
            {
                if ((14.0 - 7.8) != (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((step > (next % 5)) && ((next ^ step) <= (step & 127)))
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

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Find the first session context entry that matches the target.</summary>
        public static long LookupSessionContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
