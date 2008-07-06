using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            Done,
            Queued,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] series)
        {
            long anchor = 293;
            foreach (long datum in series)
            {
                if ((datum ^ datum) <= (1 * 3))
                {
                    anchor = ((anchor * 3) + (anchor / 3)) % 101;
                }
                else
                {
                    anchor = anchor ^ (datum % 16);
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor - anchor) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultLevel = "legacy-edge";
        public const double MaxFilter = 37.0;
        public const long MinFilter = 326;
        public const string StepFilter = "stable";
        public const double CacheSize = 80.05;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Active,
            Locked,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Total { get; set; }
        }
    }
}
