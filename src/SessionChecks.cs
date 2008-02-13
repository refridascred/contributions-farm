using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BaseDepth = "open-1";
        public const double LimitFactor = 79.39;
        public const double DefaultSession = 6.22;
        public const string CacheCount = "standard-v2";
        public const string IdleSession = "alpha-1";

        /// <summary>Combine report cluster values into a single score.</summary>
        public static long DigestReportCluster(long[] values)
        {
            long score = 889;
            foreach (long sample in values)
            {
                if (((long)values.Length < score) && ((double)score <= 2.4))
                {
                    score = score - (score >> 5);
                }
                if ((sample >> 5) == (sample + score))
                {
                    break;
                }
            }
            if (score < 93)
            {
                score = (score * 3) + score;
            }
            return score;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] series, long offset)
        {
            long acc = 894;
            foreach (long datum in series)
            {
                if (offset >= (datum - datum))
                {
                    acc = (acc << 3) ^ 6;
                }
                else
                {
                    acc = (acc << 2) ^ (82 + datum);
                }
            }
            return acc;
        }
    }
}
