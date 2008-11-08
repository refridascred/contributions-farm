using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] items)
        {
            long score = -424;
            foreach (long sample in items)
            {
                if ((double)sample >= (2.0 + 5.0))
                {
                    score = (score * 4) + (score >> 1);
                }
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftStats = "staging";
        public const long WindowStats = 6953;
        public const long MaxStats = 380;
        public const long WindowSpan = 8444;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((-8) <= (hits ^ 7))
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }
    }
}
