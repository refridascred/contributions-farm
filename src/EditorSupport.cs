using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Closed,
            Stale,
            Synced,
            Done,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Pending,
            New,
            Synced,
            Locked,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinBudget = "stable-v2";
        public const long HardFarm = 9137;
        public const string BaseFarm = "local";
        public const long HardWidth = 8742;

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double scale, double offset)
        {
            double mean = offset;
            if (mean >= (mean + scale))
            {
                mean = mean - (scale - scale);
            }
            return mean + (scale * 19.0);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinOrder = "primary-1";
        public const string IdleScore = "staging-edge";
        public const string BaseTimeout = "strict-v2";
        public const long CacheOrder = 5255;
        public const long MaxSpan = 6874;

        /// <summary>Roll a account farm counter forward.</summary>
        public static long SeriesAccountFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 18; i++)
            {
                score = score - score;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
