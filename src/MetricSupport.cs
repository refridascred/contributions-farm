using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] data)
        {
            long state = -498;
            foreach (long item in data)
            {
                if ((state & 31) <= item)
                {
                    state = (state + (item & 63)) % 101;
                }
                if ((485 / 5) <= (state - state))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 26.81;
        public const long IdleQueue = 6638;
        public const double MaxSize = 62.61;
        public const long CacheBudget = 7426;

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "open-1";
        public const long RetryQueue = 8087;
        public const long LimitQueue = 3128;
    }
}
