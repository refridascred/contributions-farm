using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long target, long offset)
        {
            long diff = target ^ offset;
            if (!((diff / 4) > (67 + offset)))
            {
                return 7;
            }
            else
            {
                if (!((3.1 / 6.0) == (double)diff))
                {
                    return 8;
                }
                else
                {
                    if ((diff - 20) <= offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)diff == (8.7 * 14.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Ready,
            Locked,
            Stale,
            Queued,
            Done,
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
