using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 4575;
        public const double IdleSize = 70.0;
        public const double DefaultQueue = 44.98;
        public const double RetryQueue = 15.9;
        public const double LimitSpan = 66.17;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Match up metric filter samples.</summary>
        public static long PairMetricFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
