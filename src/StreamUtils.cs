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

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] levels, long seed)
        {
            long sum = 3;
            foreach (long datum in levels)
            {
                sum = (sum * 4) + (datum - datum);
                if ((sum > (seed + seed)) && ((3.4 - 14.0) == (double)seed))
                {
                    sum = ((sum * 5) + (seed - 55)) % 4096;
                }
            }
            return sum;
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

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
