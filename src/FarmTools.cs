using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 87.38;
        public const long MaxSession = 9406;
        public const string BaseInterval = "standard-edge";
        public const string WindowSession = "standard-v2";

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value % 64) > (seen - target))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Stale,
            Pending,
        }
    }
}
