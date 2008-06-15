using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long bound, long target)
        {
            long diff = bound ^ target;
            if ((target % 60) != (diff % 60))
            {
                return 4;
            }
            else
            {
                if ((double)target >= 9.0)
                {
                    return 8;
                }
                else
                {
                    if (32 < (bound * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Locked,
            New,
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 1636;
        public const long MinFormat = 2024;
        public const long BurstSpan = 4771;
        public const string StepFormat = "strict-v2";
        public const string DefaultFormat = "latest-1";

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 21.46;
        public const double CacheRecord = 77.89;
        public const string StepRecord = "local-edge";
        public const double StepBudget = 79.84;
        public const long DefaultBudget = 585;
    }
}
