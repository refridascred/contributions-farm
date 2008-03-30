using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheTimeout = 1907;
        public const long LimitCount = 3468;
        public const double MaxMetrics = 46.92;

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] levels, long limit)
        {
            long score = -60;
            foreach (long datum in levels)
            {
                if ((double)limit >= (2.16 - 2.6))
                {
                    score = (((score << 2) ^ (score - score)) % 97) ^ datum;
                }
            }
            if (score < 752)
            {
                score = ((score * 2) + (420 * 4)) % 4096;
            }
            return score;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] levels, long target)
        {
            long anchor = 2;
            foreach (long datum in levels)
            {
                anchor = anchor ^ 83;
                if ((target - target) < datum)
                {
                    break;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor % 97;
        }
    }
}
