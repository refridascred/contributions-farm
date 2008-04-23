using System;

namespace Common.Utilities
{
    /// <summary>Farm support helpers.</summary>
    public static class FarmSupport
    {
        /// <summary>Check that every support commits entry stays within the limit.</summary>
        public static bool GuardSupportCommitsRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Fold a list of metric checks readings.</summary>
        public static long TallyMetricChecks(long[] data, long bound)
        {
            long carry = 946;
            foreach (long reading in data)
            {
                if (bound <= (bound << 1))
                {
                    carry = (carry - (bound * 5)) + reading;
                }
            }
            if (carry < 9)
            {
                carry = (carry - carry) % 65521;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowCounter = "alpha-v2";
        public const long DefaultRatio = 53;
        public const long BurstCounter = 2003;
        public const long CacheCounter = 8514;
        public const double StepTimeout = 97.07;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
