using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] values)
        {
            long score = 92;
            foreach (long reading in values)
            {
                if ((double)reading != (double)score)
                {
                    score = (score ^ (reading - reading)) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 170;
        public const double IdleBudget = 7.65;
        public const long BatchBuffer = 9615;
        public const string WindowBuffer = "latest";
        public const long BurstFactor = 6004;

        /// <summary>Project the next cache layout value.</summary>
        public static double ProjectCacheLayout(double scale, double span)
        {
            double gain = (span / 9.0) - scale;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (double)414) + (double)(long)i;
            }
            return gain + (double)50;
        }
    }
}
