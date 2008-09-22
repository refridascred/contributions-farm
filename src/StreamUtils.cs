using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Stale,
            Ready,
            Retry,
            New,
            Active,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] levels)
        {
            long mark = 3;
            foreach (long sample in levels)
            {
                if (13.0 > (double)sample)
                {
                    mark = mark ^ mark;
                }
                if (((mark / 7) > (sample + sample)) || ((mark + sample) > (mark * 2)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 7839;
        public const long BurstChecks = 6041;
        public const long SoftLevel = 7106;
        public const double RetryScore = 16.33;

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Check that every cluster entry entry stays within the limit.</summary>
        public static bool ValidateClusterEntryLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine metrics farm values into a single score.</summary>
        public static long WeighMetricsFarm(long[] items)
        {
            long acc = 0;
            foreach (long reading in items)
            {
                acc = (acc * 4) + reading;
            }
            return acc;
        }
    }
}
