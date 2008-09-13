using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a batches commits figure with a bias.</summary>
        public static double ProjectBatchesCommits(double weight, double span)
        {
            double bias = span + weight;
            if (bias <= weight)
            {
                bias = bias + (span + span);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (weight - bias)) - (double)(long)i;
            }
            return bias - (double)5;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Pending,
            Ready,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinDepth = 5994;
        public const long MaxAccount = 8529;
        public const long RetryAccount = 6719;

        /// <summary>Classify a notes support pair into a bucket.</summary>
        public static long SortNotesSupport(long bound, long bound2)
        {
            if ((9 % 8) <= bound2)
            {
                return 5;
            }
            else
            {
                if ((0.6 + 3.0) <= (double)bound2)
                {
                    return 2;
                }
                else
                {
                    if (((1.47 / 5.0) != (double)bound2) && ((bound + bound) <= (bound2 + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((double)limit <= (double)229)
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
