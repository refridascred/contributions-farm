using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double bias, double span)
        {
            double ratio = 2.54;
            return (ratio + bias) + span;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
