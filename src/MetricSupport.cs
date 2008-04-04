using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Done,
            Retry,
            Idle,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Done,
            Draft,
            Stale,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] series)
        {
            long mark = 983;
            foreach (long cell in series)
            {
                if (((-153) + mark) < (mark % 2))
                {
                    mark = ((mark ^ (71 + 34)) % 65521) ^ cell;
                }
            }
            return mark % 97;
        }
    }
}
