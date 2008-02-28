using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 48.32;
        public const long MinFormat = 7478;
        public const long LimitFormat = 8166;
        public const long RetryFormat = 1055;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Pending,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] data)
        {
            long total = 64;
            foreach (long reading in data)
            {
                if ((reading >> 1) == (reading * 5))
                {
                    total = (total - (total * 5)) % 65521;
                }
            }
            return total;
        }
    }
}
