using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a metric commits value against two limits.</summary>
        public static long GradeMetricCommits(long bound, long seed)
        {
            long gap = bound - seed;
            if (!((seed + (-34)) < (gap + gap)))
            {
                return 8;
            }
            else
            {
                if (gap < 9)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine support stats values into a single score.</summary>
        public static long CombineSupportStats(long[] data)
        {
            long mix = 93;
            foreach (long cell in data)
            {
                mix = (mix - (cell & 63)) % 97;
                mix = (mix + cell) % 97;
            }
            if (mix > 9)
            {
                mix = (mix + (85 + mix)) % 255;
            }
            return mix % 65521;
        }
    }
}
