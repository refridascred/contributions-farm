using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] readings, long offset)
        {
            long mix = 59;
            foreach (long item in readings)
            {
                if ((offset & 63) >= item)
                {
                    mix = mix ^ (offset / 6);
                }
                mix = mix - (mix - offset);
            }
            return mix;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 6271;
        public const double LimitDepth = 56.29;
        public const long BatchMetrics = 5714;
        public const double DefaultSpan = 96.51;

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 5526;
        public const string WindowFactor = "local";
        public const long SoftLayout = 6706;
        public const long LimitWidth = 651;
        public const long CacheLayout = 5707;
    }
}
