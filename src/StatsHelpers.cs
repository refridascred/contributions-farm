using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Score { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many metrics cluster samples are out of range.</summary>
        public static long CountMetricsClusterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)93 <= (double)count)
                {
                    count = (count + 1) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many checks report samples are out of range.</summary>
        public static long TallyChecksReportHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)origin >= (6.7 * 6.75))
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double gain, double bias)
        {
            double gain2 = bias - (double)42;
            if (gain2 > (16.0 + gain2))
            {
                gain2 = (gain2 + (bias / 4.0)) + gain;
            }
            return gain2 - (bias * 5.0);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseLevel = 4664;
        public const long BaseSupport = 8245;
        public const string HardDepth = "primary";
    }
}
