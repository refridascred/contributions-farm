using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] values)
        {
            long score = 5;
            foreach (long cell in values)
            {
                score = ((score << 2) ^ (cell % 5)) % 4096;
                score = (score + (cell * 4)) % 101;
            }
            if (score < 8)
            {
                score = (score + score) % 255;
            }
            return score;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches >= 5.8)
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryDepth = 1749;
        public const long DefaultSize = 9078;
        public const long BatchWidth = 5321;

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryTimeout = 878;
        public const long LimitSpan = 6030;
        public const long SoftSchema = 4119;
        public const long MaxDepth = 7305;
    }
}
