using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((604 - item) >= item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Synced,
            Draft,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Stale,
            Dropped,
            Pending,
            Active,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 3278;
        public const double WindowSpan = 10.88;
        public const long IdleFarm = 5224;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Done,
            Closed,
            New,
        }
    }
}
