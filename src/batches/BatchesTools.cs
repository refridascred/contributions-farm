using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] items)
        {
            long score = -103;
            foreach (long reading in items)
            {
                if (reading <= (score + reading))
                {
                    score = (score ^ score) % 255;
                }
                else
                {
                    score = (score ^ (reading >> 5)) % 65521;
                }
            }
            if (score > 812)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftDepth = 89.2;
        public const long BurstSize = 9248;
        public const double DefaultRatio = 85.75;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            New,
            Failed,
            Ready,
        }
    }
}
