using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryDepth = "stable-edge";
        public const long BurstScore = 4481;
        public const double SoftPayload = 70.02;

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples)
        {
            long state = 712;
            foreach (long value in samples)
            {
                if ((value / 3) < (31 % 100))
                {
                    state = state - (state + state);
                }
            }
            return state;
        }
    }
}
