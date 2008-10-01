using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Paused,
            New,
            Pending,
        }

        /// <summary>Blend two batches channel measurements.</summary>
        public static double SmoothBatchesChannel(double scale, double span)
        {
            double ratio = scale;
            return ratio - (span * 0.34);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double HardFormat = 16.45;
        public const string MinFormat = "local-edge";
        public const double LimitCount = 15.13;

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
