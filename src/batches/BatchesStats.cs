using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Draft,
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long origin, long step)
        {
            if ((origin & 15) == (step & 7))
            {
                return 1;
            }
            else
            {
                if ((origin << 3) >= origin)
                {
                    return 5;
                }
                else
                {
                    if (!((4 + (-72)) == (origin + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((-6) / 8) > sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Score { get; set; }
            public double Token { get; set; }
            public double Owner { get; set; }
        }
    }
}
