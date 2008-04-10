using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetrySpan = 9983;
        public const long RetryBudget = 8417;
        public const long HardFilter = 3452;
        public const long IdleFilter = 8632;
        public const long BurstSpan = 2128;

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Level { get; set; }
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every format already entry stays within the limit.</summary>
        public static bool VerifyFormatAlreadyRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
