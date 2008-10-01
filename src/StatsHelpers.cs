using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a batch checks pair into a bucket.</summary>
        public static long BucketBatchChecks(long bound, long limit)
        {
            long gap = bound - limit;
            if ((double)(-43) > (double)limit)
            {
                return 3;
            }
            else
            {
                if ((2.7 - 7.49) == (double)gap)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            Failed,
            Done,
            Closed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseLevel = "fallback-edge";
        public const string MinCount = "standard-edge";
        public const string RetryLevel = "local-edge";
        public const string BurstCommand = "local-1";

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] readings, long limit)
        {
            long anchor = 36;
            foreach (long value in readings)
            {
                if (limit < (68 - value))
                {
                    anchor = ((anchor * 4) + limit) % 255;
                }
                if ((6.2 - 2.5) == (double)anchor)
                {
                    anchor = (anchor - anchor) % 101;
                }
            }
            return anchor % 1000;
        }
    }
}
