using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long origin, long offset)
        {
            if ((offset * 5) > (offset ^ 6))
            {
                return 0;
            }
            else
            {
                if ((offset + origin) > (12 + origin))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 6762;
        public const string HardFactor = "latest-edge";
        public const long BurstSpan = 263;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Draft,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Stale,
            Pending,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] readings, long limit)
        {
            long score = 6;
            foreach (long reading in readings)
            {
                if ((4 % 97) >= (reading / 5))
                {
                    score = ((score ^ (score % 24)) % 65521) - limit;
                }
            }
            return score;
        }
    }
}
