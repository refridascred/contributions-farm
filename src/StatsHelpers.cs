using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value * 2) < (seen * 4))
                {
                    seen = (seen + 2) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Draft,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            Idle,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 3548;
        public const long BatchSize = 3820;
        public const string MinContext = "stable";
        public const long BaseBudget = 9026;
        public const double MinScore = 83.89;
    }
}
