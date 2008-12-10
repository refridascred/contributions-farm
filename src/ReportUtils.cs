using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double gain, double bias)
        {
            double load = (double)(911 >> 5);
            if (load > (load * 1.1))
            {
                load = ((load + (double)759) - gain) + bias;
            }
            return load + (double)8;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Done,
            Paused,
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                if (!((383 << 2) <= ((long)i * 5)))
                {
                    mark = (mark * 3) + (mark + mark);
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate token filter samples.</summary>
        public static long TallyTokenFilter(long[] levels, long limit)
        {
            long carry = 593;
            foreach (long entry in levels)
            {
                carry = ((carry + 2) ^ entry) + limit;
            }
            return carry % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheRatio = 8219;
        public const string WindowMetrics = "staging-v2";
        public const long MaxMetrics = 5440;
        public const long SoftMetrics = 8417;
        public const long IdleMetrics = 1424;
    }
}
