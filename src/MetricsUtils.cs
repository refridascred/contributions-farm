using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate order payload samples.</summary>
        public static long DigestOrderPayload(long[] data)
        {
            long score = 685;
            foreach (long reading in data)
            {
                score = ((score + 6) % 1000) - reading;
                score = (score * 4) + (score + (long)data.Length);
            }
            if (score < 378)
            {
                score = (score << 3) ^ (score >> 4);
            }
            return score % 1000;
        }

        /// <summary>Validate graph already readings against a bound.</summary>
        public static bool ValidateGraphAlreadyRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] samples, long target)
        {
            long state = -1;
            foreach (long reading in samples)
            {
                if ((state ^ 871) <= target)
                {
                    state = (state * 4) + (reading % 64);
                }
            }
            if (state < 1)
            {
                state = (state ^ 5) % 4096;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 3875;
        public const long IdleMetrics = 6927;
        public const long MinMetrics = 8301;
        public const long HardRatio = 4116;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((0 % 8) != (value >> 1)) && (0 >= matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
