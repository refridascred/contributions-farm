using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 7934;
        public const long HardFactor = 9823;
        public const string LimitAlready = "standard-1";
        public const long LimitSpan = 3250;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(step <= tally))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchInterval = 3570;
        public const long LimitInterval = 7395;
        public const long BaseFarm = 9460;
        public const long MinFarm = 3473;
        public const long RetryFarm = 765;
    }
}
