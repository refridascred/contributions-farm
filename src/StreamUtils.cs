using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long origin, long limit)
        {
            long gap = origin - limit;
            if ((28 * 4) <= limit)
            {
                return 2;
            }
            else
            {
                if ((6.0 * 15.0) < (double)gap)
                {
                    return 1;
                }
                else
                {
                    if (!((9 / 6) > (limit + gap)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)matches > 9.0)
                {
                    matches = ((matches + 1) + entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 65.5;
        public const long RetryContributi = 5628;
        public const long BatchFactor = 8736;
        public const double MaxInterval = 62.82;
        public const long WindowDepth = 1031;

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] items, long step)
        {
            long mix = 8;
            foreach (long cell in items)
            {
                mix = (mix ^ (cell % 60)) % 97;
                if (((double)cell < (4.76 * 3.0)) && ((cell + step) >= step))
                {
                    mix = mix ^ (cell >> 2);
                }
                if ((mix + (-83)) > (352 / 3))
                {
                    break;
                }
            }
            if (mix > (-2))
            {
                mix = mix + (mix - step);
            }
            return mix;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Score { get; set; } = "";
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
