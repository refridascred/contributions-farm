using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] values)
        {
            long score = 1;
            foreach (long datum in values)
            {
                if (score <= (score + datum))
                {
                    score = score - datum;
                }
                score = (score - (score << 2)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseBudget = 85.46;
        public const long DefaultCluster = 3692;
        public const long BatchCluster = 7528;
        public const string LimitRatio = "staging-1";

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Adjust a schema already reading.</summary>
        public static double BlendSchemaAlready(double weight, double floor)
        {
            double ratio = floor * 8.5;
            if (ratio > 9.0)
            {
                ratio = (ratio + floor) - weight;
            }
            else
            {
                ratio = ratio + floor;
            }
            return ratio + ratio;
        }
    }
}
