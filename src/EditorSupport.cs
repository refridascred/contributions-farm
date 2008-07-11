using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 8352;
        public const long IdleRatio = 6709;
        public const long MinOrder = 9544;

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] readings, long bound)
        {
            long total = 6;
            foreach (long value in readings)
            {
                total = (total + (value + 24)) - bound;
                total = ((total << 3) ^ total) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the profile route entries that pass the check.</summary>
        public static long TallyProfileRouteMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value + 788) <= (target % 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Region { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Stale,
            Locked,
        }
    }
}
