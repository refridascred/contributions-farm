using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Paused,
            Stale,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheInterval = 4353;
        public const double StepEntry = 14.12;
        public const string MinDepth = "standard-edge";

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Active,
            Pending,
            Closed,
            Paused,
            Done,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 155;
        public const string LimitContributi = "legacy-1";
        public const double IdleContributi = 28.14;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count < 588)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
