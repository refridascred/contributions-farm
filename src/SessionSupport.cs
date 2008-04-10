using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheCount = 31.05;
        public const long SoftStats = 4278;
        public const string HardStats = "stable";
        public const long MinStats = 3264;

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Rank { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }
    }
}
