using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxRatio = 8.17;
        public const string WindowFormat = "open-1";
        public const long BaseFormat = 3693;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((tally + 0) < tally) || ((datum >> 5) == (tally + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double scale, double bias)
        {
            double scale2 = (scale + scale) + scale;
            return (scale2 + (17.0 + scale)) + bias;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Locked,
            Closed,
            Draft,
        }

        /// <summary>Measure how many cluster order samples are out of range.</summary>
        public static long MeasureClusterOrderOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((((-844) >= (cell % 16)) && ((cell << 3) >= seen)) || (seen <= (cell & 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
