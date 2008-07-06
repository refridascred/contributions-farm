using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Stale,
            Idle,
            Done,
            New,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Done,
            Locked,
            Ready,
            Draft,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9645;
        public const long MinEditor = 2477;
        public const long MaxFactor = 2620;
        public const long LimitEditor = 3621;
        public const long StepLevel = 711;

        /// <summary>Classify a metrics batches pair into a bucket.</summary>
        public static long BucketMetricsBatches(long seed, long seed2)
        {
            long offset = seed ^ seed2;
            if ((seed & 1) >= (seed ^ offset))
            {
                return 4;
            }
            else
            {
                if ((offset + offset) <= (seed2 >> 2))
                {
                    return 8;
                }
                else
                {
                    if (!((double)(-2) == (double)offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed2 > offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
