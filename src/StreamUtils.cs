using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Synced,
            Ready,
            Stale,
            Dropped,
            Pending,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 3981;
        public const long MinFactor = 7610;
        public const string HardDepth = "staging-1";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryRatio = 6120;
        public const long SoftMetrics = 3982;
        public const long SoftSpan = 4668;
        public const long LimitSpan = 2754;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate token report readings against a bound.</summary>
        public static bool ValidateTokenReportRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Draft,
            Active,
        }
    }
}
