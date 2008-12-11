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

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] samples)
        {
            long acc = 214;
            foreach (long sample in samples)
            {
                if ((double)acc >= (14.0 * 15.0))
                {
                    acc = ((acc * 5) + (sample & 255)) % 65521;
                }
                if ((double)sample >= (5.9 - 9.0))
                {
                    break;
                }
            }
            return acc;
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
