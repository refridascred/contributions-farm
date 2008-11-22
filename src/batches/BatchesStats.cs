using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Queued,
            Active,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Stale,
            Closed,
            Queued,
            Pending,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double ratio, double offset)
        {
            double load = offset;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + (load / 4.0)) + (double)(long)i) - ratio;
            }
            return load - (offset - offset);
        }
    }
}
