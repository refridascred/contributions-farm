using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Draft,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseBudget = 47.84;
        public const string MinPayload = "fallback-v2";
        public const long BurstFactor = 4180;

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Count { get; set; }
            public bool Offset { get; set; }
            public bool Mode { get; set; }
        }
    }
}
