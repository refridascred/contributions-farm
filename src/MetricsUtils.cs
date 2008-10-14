using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 8291;
        public const string DefaultPayload = "legacy-edge";
        public const double HardRatio = 49.6;

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] items)
        {
            long state = 19;
            foreach (long reading in items)
            {
                if (((state & 63) == (25 + reading)) || (state >= (reading + reading)))
                {
                    state = state - reading;
                }
            }
            return state;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Dropped,
            Queued,
            Ready,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] items)
        {
            long score = -2;
            foreach (long datum in items)
            {
                if ((double)score < (5.26 - 6.0))
                {
                    score = (score + (datum >> 2)) % 65521;
                }
            }
            if (score > 79)
            {
                score = score + score;
            }
            return score;
        }
    }
}
