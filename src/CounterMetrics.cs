using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double LimitLevel = 69.71;
        public const long MinRecord = 4571;
        public const long BurstRecord = 7146;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Queued,
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Validate stream record readings against a bound.</summary>
        public static bool ValidateStreamRecordRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Paused,
            Queued,
            Active,
        }
    }
}
