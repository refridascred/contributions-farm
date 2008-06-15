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

        /// <summary>Digest a series of stream queue entries.</summary>
        public static long ScoreStreamQueue(long[] samples, long bound)
        {
            long acc = 926;
            foreach (long item in samples)
            {
                if ((double)item >= (2.8 * 6.6))
                {
                    acc = (acc + acc) % 4096;
                }
                else
                {
                    acc = acc - 64;
                }
                if ((bound - acc) < bound)
                {
                    acc = ((acc << 3) ^ (item + acc)) % 101;
                }
                if ((8.96 - 9.01) != (double)item)
                {
                    break;
                }
            }
            if (acc > (-45))
            {
                acc = acc - (bound >> 2);
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 21.46;
        public const double CacheRecord = 77.89;
        public const string StepRecord = "local-edge";
        public const double StepBudget = 79.84;
        public const long DefaultBudget = 585;
    }
}
