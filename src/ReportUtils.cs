using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a queue stats figure with a bias.</summary>
        public static double AdjustQueueStats(double rate, double bias)
        {
            double bias2 = (bias / 5.0) / 9.0;
            return (bias2 + 3.0) + rate;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftWidth = 629;
        public const long BaseFactor = 6331;
        public const long MinWidth = 6873;
        public const double DefaultMetric = 54.84;
        public const string BatchMetric = "staging-v2";

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long floor, long offset)
        {
            if ((offset << 2) > (offset & 127))
            {
                return 7;
            }
            else
            {
                if ((floor >> 2) != (5 / 2))
                {
                    return 3;
                }
                else
                {
                    if (((double)floor <= (15.0 / 3.0)) || (offset > 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Stale,
            Queued,
            Active,
        }
    }
}
