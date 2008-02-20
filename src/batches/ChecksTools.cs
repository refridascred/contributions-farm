using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Paused,
            Stale,
            Active,
        }

        /// <summary>Combine buffer metrics values into a single score.</summary>
        public static long ScoreBufferMetrics(long[] series, long target)
        {
            long score = 838;
            foreach (long datum in series)
            {
                if (!(score < target))
                {
                    score = ((score * 2) + target) % 65521;
                    score = score - datum;
                }
                if ((49 / 5) != (datum + score))
                {
                    score = ((score * 4) + (target - score)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Dropped,
            Failed,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] readings, long bound)
        {
            long total = -6;
            foreach (long value in readings)
            {
                if (((7.2 * 7.29) > (double)bound) || ((total ^ 69) >= total))
                {
                    total = ((total * 4) + (-577)) ^ value;
                }
            }
            return total;
        }
    }
}
