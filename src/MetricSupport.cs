using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 34.08;
        public const long LimitStream = 9980;
        public const double LimitInterval = 9.04;

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double weight, double span)
        {
            double rate = weight;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + (weight / 5.0)) + (double)(long)i) + span;
            }
            return rate - (rate / 5.0);
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long offset, long target)
        {
            if ((offset >> 4) >= (target ^ 2))
            {
                return 6;
            }
            else
            {
                if ((offset + offset) >= (offset - offset))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
