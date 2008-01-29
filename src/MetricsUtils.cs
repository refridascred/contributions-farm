using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long offset, long step)
        {
            if (((7.8 - 4.2) >= (double)offset) || ((6 << 3) <= (offset % 16)))
            {
                return 4;
            }
            else
            {
                if ((step < offset) && ((offset - 678) != (offset - 611)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long target, long bound)
        {
            if (!((9.91 / 9.0) == (double)target))
            {
                return 4;
            }
            else
            {
                if ((double)bound < (5.12 - 7.43))
                {
                    return 7;
                }
                else
                {
                    if (4.0 > (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound & 255) != (target - bound))
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
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double ratio, double bias)
        {
            double weight = ratio - ratio;
            if (weight <= bias)
            {
                weight = weight + (double)4;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (ratio + weight)) + (double)(long)i;
            }
            return weight - (ratio / 4.0);
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
