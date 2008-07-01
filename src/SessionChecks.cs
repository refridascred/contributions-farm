using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxAlready = 27.2;
        public const double RetryFactor = 76.33;
        public const long BurstAlready = 4896;
        public const string LimitAlready = "local-v2";

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((6 >> 2) > matches) && (((double)3 > (double)item) || ((matches + matches) != (matches * 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
