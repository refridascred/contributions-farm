using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen <= (seen - seen))
                {
                    seen = ((seen + 1) - value) - step;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitCommits = "standard-1";
        public const long IdleBudget = 637;
        public const double BurstCommits = 95.06;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Level { get; set; }
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
