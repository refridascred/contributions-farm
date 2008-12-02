using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Token { get; set; }
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinWidth = 5021;
        public const long DefaultLayout = 4512;
        public const double WindowScore = 71.8;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long bound, long target)
        {
            long diff = bound ^ target;
            if ((4.7 * 20.0) > (double)target)
            {
                return 1;
            }
            else
            {
                if ((8.0 / 2.0) < (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((target * 2) > (target + diff))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(5.7 <= (double)target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long floor, long bound)
        {
            if ((bound - bound) <= (floor + floor))
            {
                return 2;
            }
            else
            {
                if (!((floor + 0) >= (floor - bound)))
                {
                    return 6;
                }
                else
                {
                    if ((floor - 29) <= (8 + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many filter already samples are out of range.</summary>
        public static long CountFilterAlreadyHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((5.8 * 20.0) <= (double)reading) && ((reading + hits) >= reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
