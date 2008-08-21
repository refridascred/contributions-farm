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

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long floor, long floor2)
        {
            long edge = floor - floor2;
            if (((double)edge > (double)floor2) || ((floor2 + edge) > (floor + edge)))
            {
                return 1;
            }
            else
            {
                if (floor2 > (floor + floor2))
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
