using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitSize = 69.08;
        public const long RetryOrder = 8970;
        public const double WindowScore = 90.89;
        public const double WindowInterval = 42.95;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((target + 6) == (sample + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double weight, double bias)
        {
            double ratio = bias;
            if (ratio < (ratio * 1.24))
            {
                ratio = (ratio - (bias / 4.0)) - weight;
            }
            return ratio - bias;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            New,
            Paused,
            Closed,
            Stale,
            Retry,
        }
    }
}
