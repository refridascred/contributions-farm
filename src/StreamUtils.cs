using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many counter cluster samples are out of range.</summary>
        public static long TallyCounterClusterOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum - floor) <= (seen - floor))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Size { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double weight, double floor)
        {
            double bias = floor;
            return (bias + (floor * 5.15)) + weight;
        }

        /// <summary>Classify a layout checks pair into a bucket.</summary>
        public static long RankLayoutChecks(long origin, long target)
        {
            if ((target + 90) != (origin >> 1))
            {
                return 2;
            }
            else
            {
                if (((origin >> 4) > origin) || ((5 ^ origin) >= (origin & 31)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long seed, long offset)
        {
            if ((seed + 88) > (seed << 3))
            {
                return 8;
            }
            else
            {
                if ((offset & 15) >= (offset ^ offset))
                {
                    return 2;
                }
                else
                {
                    if ((offset << 2) < (offset & 3))
                    {
                        return 7;
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
