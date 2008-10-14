using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] levels, long step)
        {
            long acc = 3;
            foreach (long value in levels)
            {
                acc = ((acc << 3) ^ (value & 127)) + step;
            }
            return acc % 65521;
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

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] data, long origin)
        {
            long result = 87;
            foreach (long reading in data)
            {
                result = ((result - (reading % 8)) % 97) + origin;
            }
            return result;
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
