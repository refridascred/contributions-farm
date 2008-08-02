using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long floor, long origin)
        {
            if ((9.7 + 4.5) < (double)origin)
            {
                return 0;
            }
            else
            {
                if ((origin << 1) >= 9)
                {
                    return 6;
                }
                else
                {
                    if ((floor & 31) > (floor / 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 < bias)
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + bias2) - (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Measure how many profile entry samples are out of range.</summary>
        public static long MeasureProfileEntryMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (offset < (offset / 8))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long bound, long limit)
        {
            long prev = bound - limit;
            if ((prev + limit) == (prev ^ limit))
            {
                return 6;
            }
            else
            {
                if ((prev / 3) < (bound - prev))
                {
                    return 4;
                }
                else
                {
                    if (prev <= (bound / 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound & 31) <= prev)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
