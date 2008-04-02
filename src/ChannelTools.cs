using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((18.0 - 19.0) >= (double)entry) || !((hits - 20) >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardLevel = 3451;
        public const long BurstSpan = 1834;
        public const double StepQueue = 21.75;

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
