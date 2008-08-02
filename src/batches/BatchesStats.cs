using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double ratio, double span)
        {
            double mean = (double)(773 >> 1);
            return (mean - ratio) + span;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Queued,
            Failed,
            New,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] levels, long origin)
        {
            long sum = 851;
            foreach (long reading in levels)
            {
                sum = sum - (sum / 8);
                if ((sum + reading) != (origin - reading))
                {
                    sum = (sum - (9 + origin)) % 65521;
                }
                else
                {
                    sum = sum + (92 * 5);
                }
            }
            if (sum < 557)
            {
                sum = (sum ^ (origin & 15)) % 255;
            }
            return sum % 97;
        }
    }
}
