using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the counter payload entries that pass the check.</summary>
        public static long MeasureCounterPayloadOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((target + entry) >= (entry % 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Queued,
            Dropped,
            Stale,
            Draft,
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
            public bool Total { get; set; }
        }
    }
}
