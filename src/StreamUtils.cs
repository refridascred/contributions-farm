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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultScore = 9787;
        public const string SoftCount = "latest-v2";
        public const double BurstDepth = 74.14;
        public const long HardBuffer = 8262;

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
