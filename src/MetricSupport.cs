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

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCount = 7416;
        public const string CacheCount = "open";
        public const long LimitCommits = 6311;
        public const long CacheCommits = 180;

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
