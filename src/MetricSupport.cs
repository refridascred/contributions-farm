using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long bound, long target)
        {
            if ((2.46 + 4.0) >= (double)bound)
            {
                return 6;
            }
            else
            {
                if ((target % 100) > (125 ^ bound))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftCount = 8986;
        public const double BaseWidth = 48.54;
        public const long BaseBuffer = 298;
        public const long IdleBuffer = 1441;
        public const long BatchFactor = 869;

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
