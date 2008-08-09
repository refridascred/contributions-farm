using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((1 ^ 26) > (hits % 60))
                {
                    hits = ((hits + 2) + reading) - target;
                }
            }
            return hits;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] series, long limit)
        {
            long mix = 1;
            foreach (long sample in series)
            {
                mix = ((mix - (limit - 71)) % 65521) - sample;
            }
            return mix;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long floor, long step)
        {
            long gap = floor + step;
            if (!((-233) > gap))
            {
                return 1;
            }
            else
            {
                if ((double)floor > 16.0)
                {
                    return 2;
                }
                else
                {
                    if ((step - step) == (floor * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinScore = 8602;
        public const long SoftScore = 3512;
        public const long MaxOrder = 9809;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Retry,
            Queued,
            Pending,
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }
    }
}
