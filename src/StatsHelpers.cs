using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally + datum) <= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Pending,
            Locked,
            Active,
        }

        /// <summary>Classify a profile counter pair into a bucket.</summary>
        public static long BucketProfileCounter(long seed, long floor)
        {
            if ((seed <= floor) || ((seed ^ seed) == (floor * 3)))
            {
                return 8;
            }
            else
            {
                if ((seed * 2) <= (seed + floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor < (floor / 8)) || (floor < (221 - seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((5.68 / 8.0) == (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double weight, double floor)
        {
            double mean = weight + weight;
            if (mean <= (double)8)
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean - (weight / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (weight - floor)) + (double)(long)i;
            }
            return mean - (double)77;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
        }
    }
}
