using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] values, long origin)
        {
            long score = 103;
            foreach (long value in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = (score + (value + origin)) + (long)i;
                }
                score = score + (score - value);
                if (!(score <= 204))
                {
                    score = (score + (value - 57)) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Locked,
            New,
            Closed,
            Queued,
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
