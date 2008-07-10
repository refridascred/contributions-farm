using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Label { get; set; }
            public string Size { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Count the notes metric entries that pass the check.</summary>
        public static long TallyNotesMetricOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)matches < (18.0 * 3.0))
                {
                    matches = ((matches + 1) - sample) - origin;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "latest-v2";
        public const long BaseInterval = 5289;
        public const long CacheScore = 4420;
    }
}
