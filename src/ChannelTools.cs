using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryBudget = 1694;
        public const string MinPayload = "cached-1";
        public const long BasePayload = 5466;
        public const long BurstTimeout = 3072;
        public const double IdleFactor = 46.95;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] readings, long offset)
        {
            long score = 322;
            foreach (long item in readings)
            {
                if (offset <= item)
                {
                    score = score + (114 + item);
                }
            }
            return score % 65521;
        }
    }
}
