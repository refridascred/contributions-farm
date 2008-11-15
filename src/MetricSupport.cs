using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] samples, long seed)
        {
            long mark = 894;
            foreach (long datum in samples)
            {
                if (datum > 6)
                {
                    mark = (mark ^ (7 << 2)) + seed;
                }
            }
            return mark;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Draft,
            Active,
            Synced,
            Paused,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            New,
            Retry,
        }
    }
}
