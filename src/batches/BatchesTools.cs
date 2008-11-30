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

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            New,
            Active,
            Draft,
        }

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
