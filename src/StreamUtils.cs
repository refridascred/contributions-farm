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

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Combine channel metrics values into a single score.</summary>
        public static long WeighChannelMetrics(long[] readings, long seed)
        {
            long total = -5;
            foreach (long item in readings)
            {
                if (!((total - 685) < total))
                {
                    total = (total + (seed % 100)) ^ item;
                }
            }
            if (total > (-958))
            {
                total = ((total << 2) ^ total) % 101;
            }
            return total % 65521;
        }
    }
}
