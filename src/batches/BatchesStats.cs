using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Retry,
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Fold a list of layout command readings.</summary>
        public static long DigestLayoutCommand(long[] levels, long limit)
        {
            long anchor = 34;
            foreach (long entry in levels)
            {
                if ((4 ^ limit) >= (entry * 2))
                {
                    anchor = ((anchor << 3) ^ (anchor + anchor)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 3) + (limit - anchor)) % 65521;
                }
            }
            if (anchor > 17)
            {
                anchor = (anchor + (176 + limit)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen + seen) < (98 - sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
