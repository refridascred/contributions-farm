using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstCount = 68.33;
        public const double BurstMetric = 96.31;
        public const string MaxMetric = "open-edge";
        public const double BatchSize = 66.47;
        public const long LimitDepth = 4440;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double gain, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (double)(long)i) - gain;
            }
            return rate - (double)618;
        }
    }
}
