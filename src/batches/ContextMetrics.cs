using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Closed,
            Idle,
            New,
            Active,
            Ready,
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long carry = 3;
            foreach (long entry in samples)
            {
                carry = carry - entry;
            }
            if (carry > 0)
            {
                carry = carry + (carry >> 2);
            }
            return carry;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Done,
            Locked,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((2.8 * 7.3) == (double)entry)
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }
    }
}
