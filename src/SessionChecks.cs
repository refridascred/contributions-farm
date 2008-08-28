using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Failed,
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftMetric = 35.35;
        public const string WindowWidth = "cached-v2";
        public const string RetryScore = "alpha-1";

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double ratio, double bias)
        {
            double bias2 = (ratio - 10.0) - (double)4;
            return (bias2 - (12.0 * 2.08)) + bias;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] levels)
        {
            long acc = -3;
            foreach (long entry in levels)
            {
                acc = (acc ^ (729 << 1)) % 255;
                if ((double)(long)levels.Length < (double)entry)
                {
                    acc = (acc - (acc + acc)) % 65521;
                }
            }
            return acc;
        }
    }
}
